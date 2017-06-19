using System.Collections.Generic;

namespace Harnet.Net
{
    public class PostData
    {
        public string MimeType { get; set; }
        public string Text { get; set; }
        public List<Param> Params { get; set; }
        public string Comment { get; set; }
    }
}
