﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    [Serializable]
    public class ListModel
    {
        public int PageIndex{get;set;}
        public int PageSize{get;set;}
        public string Sort{get;set;}
        public string Direction{get;set;}
        public string QueryType { get; set; }
        public string Opt { get; set; }
        public string KeyWord { get; set; }

        public string starttime { get; set; }

        public string endtime { get; set; }
        public string KeyWord2 { get; set; }
        public string QueryString { get; set; }
        public string AuthString { get; set; }
        public string StatusString { get; set; }
        public ListModel deepClone()
        {
            ListModel clone = new ListModel();
            clone.PageIndex = this.PageIndex;
            clone.PageSize = this.PageSize;
            clone.Sort = this.Sort == null?null: new string(this.Sort.ToCharArray());
            clone.Direction = this.Direction == null ? null : new string(this.Direction.ToCharArray());
            clone.QueryType = this.QueryType == null ? null : new string(this.QueryType.ToCharArray());
            clone.KeyWord = this.KeyWord == null ? null : new string(this.KeyWord.ToCharArray());
            clone.KeyWord2 = this.KeyWord2 == null ? null : new string(this.KeyWord2.ToCharArray());
            clone.QueryString = this.QueryString == null ? null : new string(this.QueryString.ToCharArray());
            return clone;
        }

    }
}