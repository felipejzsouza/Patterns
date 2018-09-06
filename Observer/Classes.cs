using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    public abstract class Observer
    {
        public abstract void Update();
    }

    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }
    }
    
    public class Venda : Observer
    {
        private bool _state;

        private Balanco _balanco;

        public Venda(Balanco subject)
        {
            this._balanco = subject;
        }

        public void Iniciar()
        {
            if (!_state)
                Console.WriteLine("Venda iniciada...");
            else
                Console.WriteLine("Não é possivel iniciar venda...");
        }

        public override void Update()
        {
            _state = _balanco.State;
        }
    }

    public class Balanco : Subject
    {
        private bool _state = false;

        public bool State
        {
            get { return _state; }
        }

        public void Iniciar()
        {
            _state = true; 
            Console.WriteLine("Balanço iniciado...");
            Notify();
        }

        public void Finalizar()
        {
            _state = false;
            Console.WriteLine("Balanço finalizado...");
            Notify();
        }
    }
}
