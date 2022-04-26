using System;
using System.Collections.Generic;
using System.Text;

namespace CatApi.Model
{
    class CatItemModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
