using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebServer.Models
{
    public class CurrencyService : BackgroundService
    {
        private readonly IMemoryCache memoryCache;

        public CurrencyService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU"); 

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    XDocument xml = XDocument.Load("http://www.cbr.ru/scripts/XML_daily.asp");
                    CurrencyConverter currencyConverter = new CurrencyConverter();
                    currencyConverter.USD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "840").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.EUR = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "978").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.UAH10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "980").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.AUD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "036").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.AZN = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "944").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.GBP = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "826").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.AMD100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "051").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.BYN = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "933").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.BGN = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "975").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.BRL = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "986").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.HUF100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "348").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.HKD10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "344").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.DKK10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "208").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.INR100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "356").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.KZT100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "398").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.CAD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "124").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.KGS100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "417").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.CNY10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "156").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.MDL10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "498").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.NOK10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "578").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.PLN = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "985").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.RON = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "946").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.XDR = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "960").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.SGD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "702").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.TJS10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "972").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.TRY10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "949").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.TMT = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "934").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.UZS10000 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "860").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.CZK10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "203").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.SEK10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "752").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.CHF = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "756").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.ZAR10 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "710").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.KRW1000 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "410").Elements("Value").FirstOrDefault().Value);
                    currencyConverter.JPY100 = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "392").Elements("Value").FirstOrDefault().Value);
                    memoryCache.Set("key_currency", currencyConverter, TimeSpan.FromMinutes(1440));
                }
                catch (Exception )
                {
                    
                }

                await Task.Delay(50000, stoppingToken);
            }
        }
    }
}
