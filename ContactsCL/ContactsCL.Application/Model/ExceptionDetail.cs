using Newtonsoft.Json;

namespace ContactsCL.Application.Model
{
    public class ExceptionDetail
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
