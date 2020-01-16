using System;

namespace Core
{
    public class GetQuoteRequest
    {
        public Account AccountDetails { get; set; }
        public string UUID { get; set; }

        public House HouseDetails { get; set; }

    }
}
