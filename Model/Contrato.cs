using Google.Cloud.Firestore;

namespace LojaMauricio.WebAPI.Model
{
    [FirestoreData]
    public class Contrato
    {
        [FirestoreProperty]
        public string? Id { get; set; }
        [FirestoreProperty]
        public string? IDFornecedor { get; set; }
        [FirestoreProperty]
        public string? DataVencimento { get; set; }
        [FirestoreProperty]
        public string? DocContrato { get; set; }
        [FirestoreProperty]
        public bool Ativo { get; set; }
    }
}
