using HttpRequestJson.Models;
using HttpRequestJson.Service;

namespace HttpRequestJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MexService _mexService;
        private List<SymbolInfo> _symbols = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            _mexService = new MexService();
            bool status = _mexService.CheckApiStatus();
            this.Text = status ? "API OK" : "API Error";
            _symbols = _mexService.GetSymbols()
                .Where(x => x.IsSpotTradingAllowed)
                .OrderBy(x => x.Symbol)
                .ToList();
            lstSymbols.DataSource = _symbols;
        }

        private void lstSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSymbols.SelectedItem == null)
            {
                tmrVeri.Stop();
                return;
            }
            tmrVeri.Start();
            tmrVeri.Interval =1000;

        }

        private void tmrVeri_Tick(object sender, EventArgs e)
        {
            if (lstSymbols.SelectedItem == null)
            {
                tmrVeri.Stop();
                return;
            }
            SymbolInfo symbol = (SymbolInfo)lstSymbols.SelectedItem;
            decimal price = _mexService.GetSymbolsData(symbol.Symbol);
            if(price > 0)
            {
                lblInfo.Text = price.ToString("N");
            }
        }
    }
}