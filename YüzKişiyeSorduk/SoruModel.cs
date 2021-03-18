using System.Collections.ObjectModel;
using System.Windows;

namespace YüzKişiyeSorduk
{
    public class CevapModel : SoruModel
    {
        private Visibility göster = Visibility.Hidden;

        private int puan;
        private bool enPopüler;

        public Visibility Göster
        {
            get => göster;

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
            get => puan;

            set
            {
                if (puan != value)
                {
                    puan = value;
                    OnPropertyChanged(nameof(Puan));
                }
            }
        }

        public bool EnPopüler
        {
            get => enPopüler;

            set
            {
                if (enPopüler != value)
                {
                    enPopüler = value;
                    OnPropertyChanged(nameof(EnPopüler));
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
            get => metin;

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
            get => sıra;

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