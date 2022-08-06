

namespace WebServer.Models
{
    public class CurrencyConverter
    {
        public decimal USD { get; set; }
        public decimal ConvertToUSD(decimal priceRUB) => priceRUB / USD;

        public decimal EUR { get; set; }
        public decimal ConvertToEUR(decimal priceRUB) => priceRUB / EUR;

        public decimal UAH10 { get; set; }
        public decimal ConvertToUAH(decimal priceRUB) => priceRUB / UAH10 / 10;

        public decimal AUD { get; set; }
        public decimal ConvertToAUD(decimal priceRUB) => priceRUB / AUD;

        public decimal AZN { get; set; }
        public decimal ConvertToAZN(decimal priceRUB) => priceRUB / AZN;

        public decimal GBP { get; set; }
        public decimal ConvertToGBP(decimal priceRUB) => priceRUB / GBP;

        public decimal AMD100 { get; set; }
        public decimal ConvertToAMD(decimal priceRUB) => priceRUB / (AMD100 / 100);

        public decimal BYN { get; set; }
        public decimal ConvertToBYN(decimal priceRUB) => priceRUB / BYN;

        public decimal BGN { get; set; }
        public decimal ConvertToBGN(decimal priceRUB) => priceRUB / BGN;

        public decimal BRL { get; set; }
        public decimal ConvertToBRL(decimal priceRUB) => priceRUB / BRL;

        public decimal HUF100 { get; set; }
        public decimal ConvertToHUF(decimal priceRUB) => priceRUB / (HUF100 / 100);

        public decimal HKD10 { get; set; }
        public decimal ConvertToHKD(decimal priceRUB) => priceRUB / (HKD10 / 10);

        public decimal DKK10 { get; set; }
        public decimal ConvertToDKK(decimal priceRUB) => priceRUB / (DKK10 / 10);

        public decimal INR100 { get; set; }
        public decimal ConvertToINR(decimal priceRUB) => priceRUB / (INR100 / 100);

        public decimal KZT100 { get; set; }
        public decimal ConvertToKZT(decimal priceRUB) => priceRUB / (KZT100 / 100);

        public decimal CAD { get; set; }
        public decimal ConvertToCAD(decimal priceRUB) => priceRUB / CAD;

        public decimal KGS100 { get; set; }
        public decimal ConvertToKGS(decimal priceRUB) => priceRUB / (KGS100 / 100);

        public decimal CNY10 { get; set; }
        public decimal ConvertToCNY(decimal priceRUB) => priceRUB / (CNY10 / 10);

        public decimal MDL10 { get; set; }
        public decimal ConvertToMDL(decimal priceRUB) => priceRUB / (MDL10 / 10);

        public decimal NOK10 { get; set; }
        public decimal ConvertToNOK(decimal priceRUB) => priceRUB / (NOK10 / 10);

        public decimal PLN { get; set; }
        public decimal ConvertToPLN(decimal priceRUB) => priceRUB / PLN;

        public decimal RON { get; set; }
        public decimal ConvertToRON(decimal priceRUB) => priceRUB / RON;

        public decimal XDR { get; set; }
        public decimal ConvertToXDR(decimal priceRUB) => priceRUB / XDR;

        public decimal SGD { get; set; }
        public decimal ConvertToSGD(decimal priceRUB) => priceRUB / SGD;

        public decimal TJS10 { get; set; }
        public decimal ConvertToTJS(decimal priceRUB) => priceRUB / (TJS10 / 10);

        public decimal TRY10 { get; set; }
        public decimal ConvertToTRY(decimal priceRUB) => priceRUB / (TRY10 / 10);

        public decimal TMT { get; set; }
        public decimal ConvertToTMT(decimal priceRUB) => priceRUB / TMT;

        public decimal UZS10000 { get; set; }
        public decimal ConvertToUZS(decimal priceRUB) => priceRUB / (UZS10000 / 10000);

        public decimal CZK10 { get; set; }
        public decimal ConvertToCZK(decimal priceRUB) => priceRUB / (CZK10 / 10);

        public decimal SEK10 { get; set; }
        public decimal ConvertToSEK(decimal priceRUB) => priceRUB / (SEK10 / 10);

        public decimal CHF { get; set; }
        public decimal ConvertToCHF(decimal priceRUB) => priceRUB / CHF;

        public decimal ZAR10 { get; set; }
        public decimal ConvertToZAR(decimal priceRUB) => priceRUB / (ZAR10 / 10);

        public decimal KRW1000 { get; set; }
        public decimal ConvertToKRW(decimal priceRUB) => priceRUB / (KRW1000 / 1000);

        public decimal JPY100 { get; set; }
        public decimal ConvertToJPY(decimal priceRUB) => priceRUB / (JPY100 / 100);
    }
}
