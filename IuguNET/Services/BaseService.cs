namespace IuguNET.Services
{
    public abstract class BaseService
    {
        public string Token { get; set; }
        protected RequestService _requestService;

        public BaseService(string token)
        {
            Token = token;
            _requestService = new RequestService();
        }
    }
}