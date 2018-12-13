using System.Runtime.Serialization;


namespace KatalogWebservice.Model
{
    [DataContract]
    public class CatalogItem
    {
        [DataMember]
        public int ItemId { get; set; } 

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string ImgPath { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}