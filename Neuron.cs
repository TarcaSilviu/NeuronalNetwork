using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect3
{
    public class Neuron
    {
        public List<Input> inputs;
        public double result = 0;
        public double activation_output = 0;
        public double error;
        public double real_activation;
        public Neuron()
        {
            inputs = new List<Input>();
        }

        public void add_input(double x)
        {
            Input input = new Input(x, 0);
            inputs.Add(input);
        }
        public void compute_input_function(string input_function)
        {
            switch (input_function)
            {
                case "suma":
                    result = Functions.suma(inputs);
                    break;
                case "produs":
                    result = Functions.produs(inputs);
                    break;
                case "min":
                    result = Functions.min(inputs);
                    break;
                case "max":
                    result = Functions.max(inputs);
                    break;
            }
        }

        public void compute_activation_function(string activation_function,bool binary_output)
        {

            switch (binary_output)
            {
                case false:
                    real_output_compute(activation_function);
                    break;
                case true:
                    binary_output_compute(activation_function);
                    break;
            }

        }
        public void binary_output_compute(string activation_function)
        {
            switch (activation_function)
            {
                case "treapta":
                    activation_output = Functions.step_function(result);
                    break;
                case "semn":
                    activation_output = Functions.sign_function(result);
                    break;
                case "sigmoid":
                    real_activation = Functions.sigmoid_function(result);
                    activation_output = Functions.sigmoid_function_binary(result);
                    break;
                case "tanh":
                    activation_output = Functions.tanh_function_binary(result);
                    break;
                case "rampa":
                    activation_output = Functions.linear_function_binary(result);
                    break;
            }
        }
        public void real_output_compute(string activation_function)
        {
            switch (activation_function)
            {
                case "treapta":
                    activation_output = Functions.step_function(result);
                    break;
                case "semn":
                    activation_output = Functions.sign_function(result);
                    break;
                case "sigmoid":
                    activation_output = Functions.sigmoid_function(result);
                    break;
                case "tanh":
                    activation_output = Functions.tanh_function(result);
                    break;
                case "rampa":
                    activation_output = Functions.linear_function(result);
                    break;
            }
        }

        public void compute_output_type_error(double target)
        {                  
            error = (target - activation_output) * real_activation * (1 - real_activation);
        }

    }
}
