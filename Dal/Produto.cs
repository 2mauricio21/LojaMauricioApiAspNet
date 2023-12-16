using LojaMauricio.WebAPI.Dal.Repositories;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace LojaMauricio.WebAPI.Dal
{
    public class Produto : IProduto
    {
        string projectId;
        FirestoreDb fireStoreDb;
        public Produto()
        {
            string arquivoApiKey = Utils.Settings.arquivoApiKey;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", arquivoApiKey);
            projectId = Utils.Settings.projectId;
            fireStoreDb = FirestoreDb.Create(projectId);
        }
        public async Task<List<Model.Produto>> GetProdutos()
        {
            try
            {
                Query ProdutoQuery = fireStoreDb.Collection("Produto");
                QuerySnapshot produtoQuerySnaphot = await ProdutoQuery.GetSnapshotAsync();
                List<Model.Produto> listaProduto = new List<Model.Produto>();
                foreach (DocumentSnapshot documentSnapshot in produtoQuerySnaphot.Documents)
                {
                    if (documentSnapshot.Exists)
                    {
                        Dictionary<string, object> city = documentSnapshot.ToDictionary();
                        string json = JsonConvert.SerializeObject(city);
                        Model.Produto novoProduto = JsonConvert.DeserializeObject<Model.Produto>(json)!;
                        novoProduto.Id = documentSnapshot.Id;
                        listaProduto.Add(novoProduto);
                    }
                }
                List<Model.Produto> listaProdutoOrdenada = listaProduto.OrderBy(x => x.Nome).ToList();
                return listaProdutoOrdenada;
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                throw;
            }
        }
        public async Task<Model.Produto> GetProduto(string id)
        {
            try
            {
                DocumentReference docRef = fireStoreDb.Collection("Produto").Document(id);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Model.Produto produto = snapshot.ConvertTo<Model.Produto>();
                    produto.Id = snapshot.Id;
                    return produto;
                }
                else
                {
                    return new Model.Produto();
                }
            }
            catch
            {
                throw;
            }
        }
        public string AddProduto(Model.Produto produto)
        {
            try
            {
                CollectionReference colRef = fireStoreDb.Collection("Produto");
                var id = colRef.AddAsync(produto).Result.Id;
                var shardRef = colRef.Document(id.ToString());
                shardRef.UpdateAsync("Id", id);
                return id;
            }
            catch
            {
                return "Error";
            }
        }
        public async void UpdateProduto(Model.Produto produto)
        {
            try
            {
                DocumentReference produtoRef = fireStoreDb.Collection("Produto").Document(produto.Id);
                await produtoRef.SetAsync(produto, SetOptions.Overwrite);
            }
            catch
            {
                throw;
            }
        }
        public async void DeleteProduto(string id)
        {
            try
            {
                DocumentReference ProdutoRef = fireStoreDb.Collection("Produto").Document(id);
                await ProdutoRef.DeleteAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
