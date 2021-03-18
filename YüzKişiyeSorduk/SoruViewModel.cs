using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace YüzKişiyeSorduk
{
    public class SoruViewModel
    {
        private readonly string xmlpath = AppDomain.CurrentDomain.BaseDirectory + @"\Data.xml";

        public SoruViewModel()
        {
            Sorular = new ObservableCollection<SoruModel>();
            Göster = new RelayCommand<object>(parameter =>
            {
                (parameter as CevapModel).Göster = Visibility.Visible;
                if (Cevaplar.Max(z=>z.Puan) == (parameter as CevapModel)?.Puan)
                {
                    (parameter as CevapModel).EnPopüler = true;
                }
            }, parameter => true);

            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                XElement xElement = XElement.Load(xmlpath);
                foreach (XElement soru in xElement?.Elements())
                {
                    Cevaplar = new ObservableCollection<CevapModel>();
                    foreach (XElement cevap in (soru.FirstNode as XElement)?.Elements())
                    {
                        Cevaplar.Add(new CevapModel() { Metin = (string)cevap.Attribute("Metin"), Sıra = (int)cevap.Attribute("Sıra"), Puan = (int)cevap.Attribute("Puan") });
                    }
                    SoruModel soruModel = new SoruModel() { Metin = (string)soru.Attribute("Metin"), Sıra = (int)soru.Attribute("Sıra"), Cevaplar = Cevaplar };
                    Sorular.Add(soruModel);
                }
            }
        }

        public ObservableCollection<CevapModel> Cevaplar { get; set; }

        public ICommand Göster { get; }

        public ObservableCollection<SoruModel> Sorular { get; set; }
    }
}