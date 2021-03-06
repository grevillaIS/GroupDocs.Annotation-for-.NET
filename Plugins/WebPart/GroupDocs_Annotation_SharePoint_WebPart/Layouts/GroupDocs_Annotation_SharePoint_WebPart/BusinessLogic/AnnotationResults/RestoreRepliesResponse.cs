﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults
{
    [DataContract]
    public class RestoreRepliesResult : Result
    {
        [XmlElement("annotationGuid")]
        [DataMember(Name = "annotationGuid")]
        public string AnnotationGuid { get; set; }

        [XmlElement("ids")]
        [DataMember(Name = "ids")]
        public string[] ReplyIds { get; set; }
    }
}
