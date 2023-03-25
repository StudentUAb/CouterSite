using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa o driver do Chrome
        IWebDriver driver = new ChromeDriver();

        // Navega até o site desejado
        driver.Navigate().GoToUrl("https://www.ivo.com.pt");
        for (int i = 0; i < 2; i++)
        {
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5000); // aguarda 5 segundos antes de atualizar novamente
        }
        driver.Navigate().GoToUrl("https://www.ivo.com.pt/works/");
        for (int i = 0; i < 2; i++)
        {
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5000); // aguarda 5 segundos antes de atualizar novamente
        }
        driver.Navigate().GoToUrl("https://ivo.com.pt/about-me/");
        // Repita o processo de visitar o site algumas vezes
        for (int i = 0; i < 2; i++)
        {
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5000); // aguarda 5 segundos antes de atualizar novamente
        }
        driver.Navigate().GoToUrl("https://www.ivo.com.pt");
        for (int i = 0; i < 2; i++)
        {
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5000); // aguarda 5 segundos antes de atualizar novamente
        }
        // Fecha o driver do Chrome
        driver.Quit();
    }
}

