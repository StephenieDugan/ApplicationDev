using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfTheNewRepublic.UI
{
    internal class Character : INotifyPropertyChanged
    {
        private int strength;
        private int dexterity;
        private int intelligence;
        private int constitution;
        private int forcePower;
        private int midichlorians;
        private int charisma;
        public event PropertyChangedEventHandler? PropertyChanged;
        public Character()
        {
            strength = 8;
            dexterity = 8;
            intelligence = 8;
            constitution = 8;
            forcePower = 8;
            midichlorians = 8;
            charisma = 8;
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }



        public int Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                this.strength = value;
                NotifyPropertyChanged();
            }
        }

        public int Dexterity
        {
            get
            {
                return this.dexterity;
            }
            set
            {
                this.dexterity = value;
                NotifyPropertyChanged();
            }
        }
        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                this.intelligence = value;
                NotifyPropertyChanged();
            }
        }
        public int Constitution
        {
            get
            {
                return this.constitution;
            }
            set
            {
                this.constitution = value;
                NotifyPropertyChanged();
            }
        }
        public int ForcePower
        {
            get
            {
                return this.forcePower;
            }
            set
            {
                this.forcePower = value;
                NotifyPropertyChanged();
            }
        }
        public int Midichlorians
        {
            get
            {
                return this.midichlorians;
            }
            set
            {
                this.midichlorians = value;
                NotifyPropertyChanged();
            }
        }
        public int Charisma
        {
            get
            {
                return this.charisma;
            }
            set
            {
                this.charisma = value;
                NotifyPropertyChanged();
            }
        }
    }
}
