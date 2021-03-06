﻿using System.ServiceModel;

namespace SoapProviderCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService 
    {
        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Subtract(double a, double b);

        [OperationContract]
        double Product(double a, double b);

        [OperationContract]
        double Division(double a, double b);

        [OperationContract]
        double Sum(double[] numbers);
    }



}
