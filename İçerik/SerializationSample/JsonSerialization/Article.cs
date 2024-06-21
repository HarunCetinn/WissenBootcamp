using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    [DataContract]
    public class Article
    {
        [DataMember(Name = "Article ID",Order =1)]
        public int ArticleID {  get; set; }
        [DataMember(Name ="Article Name",Order =2)]
        public string ArticleName {  get; set; }
        [DataMember(Order =3)]
        public string ArticleDescription {  get; set; }
        [DataMember(Order =3)]
        public List<string> ArticleSiteList { get; set; }
    }
}

