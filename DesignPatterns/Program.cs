using DesignPatterns.AdapterPattern.Adapter;
using DesignPatterns.AdapterPattern.Entities;
using DesignPatterns.DecoratorPattern.ConcreteCondiments;
using DesignPatterns.ObserverPattern.Observers;
using DesignPatterns.ObserverPattern.Subjects;
using DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior;
using DesignPatterns.StrategyPattern.Entities;
using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //teste com o StrategyPattern
            MallardDuck a = new MallardDuck();
            a.SetFlyBehaviour(new FlyNoWay());
            a.PerformFlyBehaviour();
            WeatherData weatherData = new WeatherData();

            //observer
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);

            //Adapter Pattern
            IDuck turkeyAdapter = new TurkeyAdapter(new Turkey());
            turkeyAdapter.PerformQuack();
            turkeyAdapter.PerformFlyBehaviour();

            //decorator
            var beverage = new DecoratorPattern.Espresso();
            var expressoWithMocha = new Mocha(beverage);
            var price = expressoWithMocha.cost();

        }
    }

}
