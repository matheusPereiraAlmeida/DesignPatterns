﻿namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface Observer
    {   
        void update(float temp, float humidity, float pressure);
    }
}
