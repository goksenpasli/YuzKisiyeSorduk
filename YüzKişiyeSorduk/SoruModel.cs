using System.Collections.ObjectModel;
using System.Windows;

namespace YüzKişiyeSorduk
{
    public class CevapModel : SoruModel
    {
        private Visibility göster = Visibility.Hidden;

        private int puan;

        public Visibility Göster
        {
            get { return göster; }

            set
            {
                if (göster != value)
                {
                    göster = value;
                    OnPropertyChanged(nameof(Göster));
                }
            }
        }

        public int Puan
        {
            get { return puan; }

            set
            {
                if (puan != value)
                {
                    puan = value;
                    OnPropertyChanged(nameof(Puan));
                }
            }
        }
    }

    public class SoruModel : InpcBase
    {
        private string metin;

        private int sıra;

        public ObservableCollection<CevapModel> Cevaplar { get; set; }

        public string Metin
        {
            get { return metin; }

            set
            {
                if (metin != value)
                {
                    metin = value;
                    OnPropertyChanged(nameof(Metin));
                }
            }
        }

        public int Sıra
        {
            get { return sıra; }

            set
            {
                if (sıra != value)
                {
                    sıra = value;
                    OnPropertyChanged(nameof(Sıra));
                }
            }
        }
    }
}