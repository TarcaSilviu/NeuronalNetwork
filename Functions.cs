using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect3
{
    public class Functions
    {
        public static double teta = 0, G_variable = 1, A_variable = 1;

        public Functions()
        {

        }

        public static double suma(List<Input> inputs)
        {
            double result = 0;

            if (inputs.Count != 0)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    result += inputs[i].x * inputs[i].w;
                }
            }
            return result;
        }
        public static double produs(List<Input> inputs)
        {
            double result = 1;

            if (inputs.Count != 0)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    result *= inputs[i].x * inputs[i].w;
                }
            }
            return result;
        }
        public static double min(List<Input> inputs)
        {
            double min = 99999999900;

            if (inputs.Count != 0)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    if (min > (inputs[i].x * inputs[i].w))
                    {
                        min = inputs[i].x * inputs[i].w;
                    }
                }
            }
            return min;
        }
        public static double max(List<Input> inputs)
        {
            double max = 0;

            if (inputs.Count != 0)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    if (max < (inputs[i].x * inputs[i].w))
                    {
                        max = inputs[i].x * inputs[i].w;
                    }
                }
            }
            return max;
        }

        //functii de iesire
        public static double step_function(double result)
        {
            if (result >= 0)
            {
                return 1;
            }
            else return 0;
        }
        public static double sign_function(double result)
        {
            if (result >= 0)
            {
                return -1;
            }
            else return 1;
        }

        public static double sigmoid_function(double result)
        {
            double output = 1 / (1 + Math.Exp(-G_variable * (result - teta)));

            return output;
        }

        public static double sigmoid_function_binary(double result)
        {
            double output = 1 / (1 + Math.Exp(-G_variable * (result - teta)));
            if (output >= 0.5)
            {
                return 1;
            }
            else return 0;
        }

        public static double tanh_function(double result)
        {
            double output = (Math.Exp(G_variable * (result - teta)) - Math.Exp(-G_variable * (result - teta))) / (Math.Exp(G_variable * (result - teta)) + Math.Exp(-G_variable * (result - teta)));

            return output;
        }

        public static double tanh_function_binary(double result)
        {
            double output = (Math.Exp(G_variable * (result - teta)) - Math.Exp(-G_variable * (result - teta))) / (Math.Exp(G_variable * (result - teta)) + Math.Exp(-G_variable * (result - teta)));

            if (output >= 0)
            {
                return 1;
            }
            else return -1;
        }

        public static double linear_function(double result)
        {
            if (result < -(1 / A_variable))
            {
                return -1;
            }
            else if (result > (1 / A_variable))
            {
                return 1;
            }
            else
            {
                return (result * A_variable);
            }
        }
        public static double linear_function_binary(double result)
        {
            double output = linear_function(result);

            if (output >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}


