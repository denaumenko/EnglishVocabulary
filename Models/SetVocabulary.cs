using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishVocabulary.Models
{
	//Таблиця слів
	public class SetVocabulary
	{
		public int SetId { get; set; }

		public string Word { get; set; }

		public string Definition { get; set; }

		public string Category { get; set; }
	}
}

