using System.Collections.Generic;

namespace Harnet.Dto
{
    public class ResponseDto
    {
        public int status { get; set; }
        public string statusText { get; set; }
        public string httpVersion { get; set; }
        public List<object> headers { get; set; }
        public List<object> cookies { get; set; }
        public ContentDto content { get; set; }
        public string redirectURL { get; set; }
        public int headersSize { get; set; }
        public int bodySize { get; set; }
        public string comment { get; set; }
    }
}
