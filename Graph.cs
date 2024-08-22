using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace IAProiect3
{
    public partial class Graph : Form
    {
        int X = 3;

        public static int InputNeurons = 6;
        public static int OutputNeurons = 1;
        public static int HiddenLayers = 1;
        public static int HiddenLayer1 = 12, HiddenLayer2 = 0, HiddenLayer3 = 0;

        public static int global_list_count;
        public static double learning_rate=0.2;

        public static string global_input_function = "suma";
        public static string global_activation_function = "sigmoid";

        public static List<string> hidden_layers_input_functions;
        public static List<string> hidden_layers_activation_functions;

        public static bool binary_output = false;

        public static List<int> hidden_layers_neurons;

        public static List<Neuron> input_neurons_list;
        public static List<Neuron> output_neurons_list;

        public static List<Layer> hidden_layers;
        public static List<List<Button>> hidden_layer_buttons;

        public static double generation_error;
        public static double generation_error_sum;
        public static double desired_error=0.1;
        public static int generation=1;

        
        public bool Run=false;
        public double test_score;

        public static List <SurveyData> executionData = new List<SurveyData>();

        public Graph()
        {           
            InitializeComponent();
            executionData.Add(new SurveyData(1, 1, 1, 1, 1, 1, 1));
            

            ThreadPool.SetMinThreads(32, 32);
        }

        public static void GenerateNeuronalNetwork()
        {
            generation_error_sum = 0;
            generation_error = 0;
            global_list_count = 0;

            hidden_layers_neurons=new List<int>();

            hidden_layers_neurons.Add(HiddenLayer1);
            hidden_layers_neurons.Add(HiddenLayer2);
            hidden_layers_neurons.Add(HiddenLayer3);

            input_neurons_list = new List<Neuron>() { };
            output_neurons_list = new List<Neuron>() { };

            hidden_layers_input_functions = new List<string>() { "suma", "suma", "suma" };
            hidden_layers_activation_functions = new List<string>() { "tanh", "tanh", "tanh" };

            generate_input_neurons();
            generate_hidden_layers();
            generate_output_neurons();

            first_step_computation();
        }


        public static void InitInputs(List<SurveyData> input_list)
        {
            input_neurons_list[0].inputs[0].x = input_list[global_list_count].q1;
            input_neurons_list[0].activation_output = input_neurons_list[0].inputs[0].x;
            input_neurons_list[1].inputs[0].x = input_list[global_list_count].q2;
            input_neurons_list[1].activation_output = input_neurons_list[1].inputs[0].x;
            input_neurons_list[2].inputs[0].x = input_list[global_list_count].q3;
            input_neurons_list[2].activation_output = input_neurons_list[2].inputs[0].x;
            input_neurons_list[3].inputs[0].x = input_list[global_list_count].q4;
            input_neurons_list[3].activation_output = input_neurons_list[3].inputs[0].x;
            input_neurons_list[4].inputs[0].x = input_list[global_list_count].q5;
            input_neurons_list[4].activation_output = input_neurons_list[4].inputs[0].x;
            input_neurons_list[5].inputs[0].x = input_list[global_list_count].q6;
            input_neurons_list[5].activation_output = input_neurons_list[5].inputs[0].x;

        }

        //Generate neurons in lists
        public static void generate_input_neurons()
        {
            for (int i = 0; i < InputNeurons; i++)
            {
                Neuron neuron = new Neuron();
                neuron.add_input(0);
                input_neurons_list.Add(neuron);
            }
            

        }
        public static void generate_output_neurons()
        {
            for (int i = 0; i < OutputNeurons; i++)
            {
                Neuron neuron = new Neuron();

                output_neurons_list.Add(neuron);
            }

        }
        public static void generate_hidden_layers()
        {
            hidden_layers = new List<Layer>() { };
            hidden_layer_buttons = new List<List<Button>>();

            for (int i = 0; i < HiddenLayers; i++)
            {
                Layer hidden_layer = new Layer();
                List<Button> buttons = new List<Button>();

                hidden_layer_buttons.Add(buttons);
                generate_neurons_in_hidden_layer(hidden_layer, hidden_layers_neurons[i]);
                hidden_layers.Add(hidden_layer);
            }
        }
        public static void generate_neurons_in_hidden_layer(Layer x, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Neuron neuron = new Neuron();
                x.hidden_layer.Add(neuron);
            }
        }     
      
        //Computation steps
        public static void first_step_computation()
        {
            foreach (Neuron x in input_neurons_list)
            {
                for (int i = 0; i < HiddenLayer1; i++)
                {
                    hidden_layers[0].hidden_layer[i].add_input(x.inputs[0].x);
                }
            }
            for (int i = 1; i < HiddenLayers; i++)
            {
                for (int j = 0; j < hidden_layers_neurons[i]; j++)
                {
                    for (int k = 0; k < hidden_layers_neurons[i - 1]; k++)
                    {
                        hidden_layers[i].hidden_layer[j].add_input(0);
                    }
                }
            }
            foreach (Neuron x in output_neurons_list)
            {
                for (int i = 0; i < hidden_layers_neurons[HiddenLayers - 1]; i++)
                {
                    x.add_input(0);
                }
            }
            RandomiseWeights();
        }

        public static void compute(List<SurveyData> input_list)
        {
            ResetInputs(input_list);
            hidden_layer_computation();
            output_layer_computation();
        }

        public static void RandomiseWeights()
        {
            Random rand = new Random();
            double min = -1;
            double max = 1;
            double range = max - min;

            for (int i = 0; i < OutputNeurons; i++)
            {
                for (int j = 0; j < hidden_layers_neurons[HiddenLayers - 1]; j++)
                {
                    double sample = rand.NextDouble();
                    double scaled = (sample * range) + min;
                    output_neurons_list[i].inputs[j].w = scaled;
                }
            }
            for (int i = 0; i < HiddenLayers; i++)
            {
                for (int j = 0; j < hidden_layers_neurons[i]; j++)
                {
                    foreach (Input x in hidden_layers[i].hidden_layer[j].inputs) {
                        double sample = rand.NextDouble();
                        double scaled = (sample * range) + min;
                        x.w= scaled; 
                    }
                }
            }
        }
        public static void hidden_layer_computation()
        {
            
            for (int i = 0; i < HiddenLayers; i++)
            {
                for (int j = 0; j < hidden_layers_neurons[i]; j++)
                {
                    hidden_layers[i].hidden_layer[j].compute_input_function(hidden_layers_input_functions[i]);
                    hidden_layers[i].hidden_layer[j].compute_activation_function(hidden_layers_activation_functions[i], false);
                }
                if (i == (HiddenLayers - 1))
                {
                    break;
                }
                else
                {
                    for (int j = 0; j < hidden_layers_neurons[i]; j++)
                    {
                        for (int k = 0; k < hidden_layers_neurons[i + 1]; k++)
                        {
                            hidden_layers[i + 1].hidden_layer[k].inputs[j].x = hidden_layers[i].hidden_layer[j].activation_output;
                        }
                    }
                }

            }
        }

        private static void ResetInputs(List<SurveyData> input_list)
        {
            InitInputs(input_list);
            for (int i = 0; i < InputNeurons; i++)
            {
                for (int j = 0; j < HiddenLayer1; j++)
                {
                    hidden_layers[0].hidden_layer[j].inputs[i].x = input_neurons_list[i].inputs[0].x;
                }
            }
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.ShowDialog();
        }

        public static void output_layer_computation()
        {
            for (int i = 0; i < OutputNeurons; i++)
            {
                for (int j = 0; j < hidden_layers_neurons[HiddenLayers - 1]; j++)
                {
                    output_neurons_list[i].inputs[j].x = hidden_layers[HiddenLayers - 1].hidden_layer[j].activation_output;
                }
            }
            for (int i = 0; i < OutputNeurons; i++)
            {
                output_neurons_list[i].compute_input_function(global_input_function);
                output_neurons_list[i].compute_activation_function(global_activation_function,true);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input_list">Its the list of neurons which you want to calculate the error</param>
        /// <param name="right_list">Its the list of the layer of neurons to the right</param>
        public void compute_hidden_layer_error(List <Neuron> input_list, List<Neuron> right_list)
        {
            double sum = 0;

            for (int i = 0; i < input_list.Count; i++)
            {
                for (int j=0;j<right_list.Count;j++)
                {
                    sum+=right_list[j].error * right_list[j].inputs[i].w;
                }
                input_list[i].error = sum * input_list[i].activation_output * (1 - input_list[i].activation_output);
            }
        }
        public void compute_output_layer_error()
        {
            foreach(Neuron x in output_neurons_list)
            {
                x.compute_output_type_error(NormalisedData.normalisedData[global_list_count].result);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input_layer">The layer you want to chagne the weights</param>
        /// <param name="left_layer">The layer to the left</param>
        public void compute_hidden_layer_weights(List<Neuron> left_layer,List <Neuron> input_layer)
        {
            for (int i = 0; i < input_layer.Count; i++)
            {
                for (int j = 0; j < input_layer[i].inputs.Count; j++)
                {
                    input_layer[i].inputs[j].w += (learning_rate * input_layer[i].error * left_layer[j].activation_output);

                }
            }
        }
        public void compute_error_and_weights()
        {
            compute_output_layer_error();
            compute_output_layer_weights();

            switch (HiddenLayers) {
                case 1:
                    compute_hidden_layer_error(hidden_layers[0].hidden_layer, output_neurons_list);
                    compute_hidden_layer_weights(input_neurons_list, hidden_layers[0].hidden_layer);
                    break;
                case 2:
                    compute_hidden_layer_error(hidden_layers[1].hidden_layer, output_neurons_list);
                    compute_hidden_layer_weights(hidden_layers[0].hidden_layer, hidden_layers[1].hidden_layer);

                    compute_hidden_layer_error(hidden_layers[0].hidden_layer, hidden_layers[1].hidden_layer);
                    compute_hidden_layer_weights(input_neurons_list, hidden_layers[0].hidden_layer);
                    break;
                case 3:
                    compute_hidden_layer_error(hidden_layers[2].hidden_layer, output_neurons_list);
                    compute_hidden_layer_weights(hidden_layers[1].hidden_layer, hidden_layers[2].hidden_layer);

                    compute_hidden_layer_error(hidden_layers[1].hidden_layer, hidden_layers[2].hidden_layer);
                    compute_hidden_layer_weights(hidden_layers[0].hidden_layer, hidden_layers[1].hidden_layer);

                    compute_hidden_layer_error(hidden_layers[0].hidden_layer, hidden_layers[1].hidden_layer);
                    compute_hidden_layer_weights(input_neurons_list, hidden_layers[0].hidden_layer);
                    break;
            }
            compute_step_error();

            global_list_count++;

        }
        public void compute_output_layer_weights()
        {
            for (int i = 0; i < output_neurons_list.Count; i++)
            {
                for (int j = 0; j < output_neurons_list[i].inputs.Count; j++)
                {
                    output_neurons_list[i].inputs[j].w +=  (learning_rate * output_neurons_list[i].error * hidden_layers[HiddenLayers - 1].hidden_layer[j].activation_output);

                }
            }
        }

        public void compute_step_error()
        {
            double stepError = ((double)1 / 2) * Math.Pow(output_neurons_list[0].activation_output - NormalisedData.normalisedData[global_list_count].result, 2);
            generation_error_sum += stepError;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            GenerateNeuronalNetwork();

            errorChart.Series["Series1"].Points.Clear();
            startBtn.Enabled = false;
            configBtn.Enabled = false;
            stopBtn.Enabled = true;
            testResultBtn.Enabled = false;
            Run = true;
            /* chartThread = new Thread(new ThreadStart(final_computation));
             chartThread.IsBackground = true;
             chartThread.Start();*/

            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (Run)
                {

                    final_computation();
               
                        errorChart.Invoke((Action)(() =>
                        {
                            errorChart.Series["Series1"].Points.AddXY(generation, generation_error);
                        }));
                        errorTextBox.Invoke((Action)(() =>
                        {
                            errorTextBox.Text = generation_error.ToString();
                        }));
                    if (desired_error > generation_error)
                    {
                        Run = false;
                        startBtn.Invoke((Action)(() =>
                        {
                            startBtn.Enabled = true;
                        }));
                        configBtn.Invoke((Action)(() =>
                        {
                            configBtn.Enabled = true;
                        }));
                        stopBtn.Invoke((Action)(() =>
                        {
                            stopBtn.Enabled = false;
                        }));
                        testResultBtn.Invoke((Action)(() =>
                        {
                            testResultBtn.Enabled = true;
                        }));

                    }
                    generation_error = 0;
                        global_list_count = 0;
                        generation_error_sum = 0;
                        generation++;
                    
                    Thread.Sleep(1000);
                }
                
                
                
            });
           
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            configBtn.Enabled = true;
            stopBtn.Enabled = false;
            testResultBtn.Enabled = true;
            Run = false;
            
        }

        public void compute_generations_error()
        {
            generation_error = (1 / (double)global_list_count)* generation_error_sum;
        }

        private void testResultBtn_Click(object sender, EventArgs e)
        {
            compute_test_score();
            testResultTextBox.Text = test_score.ToString() + "%";
        }

        private void executionBtn_Click(object sender, EventArgs e)
        {
            xeAboutBox1 xeAboutBox = new xeAboutBox1();
            xeAboutBox.ShowDialog();
        }

        public void final_computation()
        {            
            
                while (global_list_count < NormalisedData.normalisedData.Count)
                {
                    compute(NormalisedData.normalisedData);
                    compute_error_and_weights();
                }
                compute_generations_error();
                            
           // chartThread.Abort();
        }

        
        public void compute_test_score()
        {
            global_list_count = 0;
            test_score = 0;
            foreach (SurveyData x in NormalisedData.normalisedTestData)
            {   
                compute(NormalisedData.normalisedTestData);
                if (output_neurons_list[0].activation_output == x.result)
                {
                    test_score++;
                }
                global_list_count++;
            }
            test_score = (test_score / global_list_count) * 100;
            global_list_count = 0;
        }
        
    }
}