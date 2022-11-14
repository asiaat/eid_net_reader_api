namespace api.Application.Models
{
    public class IDCard
    {
        public IDCard()
        {
        }
        public string System { get; set; }
        public string Protocol { get; set; }
        public string Err { get; set; }
        public string ReaderName { get; set; }
        public string State { get; set; }
        public string CardAttr { get; set; }
        public string Msg { get; set; }

        // Methods
        public void SetErr(string err)
        {
            Err = err;
        }

        public void SetMsg(string msg)
        {
            Msg = msg;
        }
    }
}
