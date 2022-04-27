using System.Collections.Generic;

namespace WordMaster.Models
{
    public class WordDefinitionViewModel
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int LangId { get; set; }


        public string LangCode { get; set; }
        public string LangName { get; set; }

        public List<WordMeaningViewModel> Meanings { get; set; }
    }
}
