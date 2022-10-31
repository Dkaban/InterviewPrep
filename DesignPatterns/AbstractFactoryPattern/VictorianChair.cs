using System;

namespace Patterns.AbstractFactory
{
    public class VictorianChair : IChair
    {
        private readonly bool _chairHasLegs;
        private readonly bool _personCanSit;
        public VictorianChair(bool hasLegs, bool canSit)
        {
            _chairHasLegs = hasLegs;
            _personCanSit = canSit;
            Console.WriteLine("Victorian Chair Created!");
        }
        
        public bool HasLegs()
        {
            return _chairHasLegs;
        }

        public bool CanSitOn()
        {
            return _personCanSit;
        }
    }
}