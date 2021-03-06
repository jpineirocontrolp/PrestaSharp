﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PrestaSharp.Lib;

namespace PrestaSharp.Entities
{
    [XmlType(Namespace = "PrestaSharp/Entities")]
    public class country : PrestashopEntity
    {
        public long? id { get; set; }

		/// <summary>
		/// Required
		/// </summary>
		public uint id_zone { get; set; }

		public uint? id_currency { get; set; }
		public int? call_prefix { get; set; }

		/// <summary>
		/// Required. maxSize = 3
		/// </summary>
		public String iso_code { get; set; }

		public sbyte? active { get; set; }

		/// <summary>
		/// Required
		/// </summary>
		public sbyte contains_states { get; set; }

		/// <summary>
		/// Required
		/// </summary>
		public sbyte need_identification_number { get; set; }

		public sbyte? need_zip_code { get; set; }

		/// <summary>
		/// Must be like "NNNNN" or "LNL NLN" where N=Number and L=Letter
		/// </summary>
		public string zip_code_format { get; set; }

		/// <summary>
		///  Required
		/// </summary>
		public sbyte display_tax_label { get; set; }

		/// <summary>
		/// Required. Maxsize = 64
		/// </summary>
        public List<Entities.AuxEntities.language> name { get; set; }

        public country()
        {
            this.name = new List<AuxEntities.language>();
        }

    }
}
