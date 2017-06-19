namespace Harnet.Dto
{
    public class PostDataDto
    {
        public string mimeType { get; set; }
        public string text { get; set; }
        public ParamDto[] @params { get; set; }
        public string comment { get; set; }
    }
}
