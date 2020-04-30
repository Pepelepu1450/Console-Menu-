using System;
using System.Collections.Generic;


namespace Console_Menu_
{
    class Menu
    {
        /*

        ¡Bienvenido a la nevería!

        1) Tipo de cono
        2) Sabor de nieve
        3) Sencillo, doble o triple

        6) Pagar

        9) Salir

        */

        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 });
        List<int> selectConeOptions = new List<int>(new int[] { 1, 2, 9 });
        List<int> selectFlavorOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 });
        List<int> selectSizeOptions = new List<int>(new int[] { 1, 2, 3, 9 });

        private string tipoCono = "Regular";
        private string sabor = "Chocolate";
        private string tamaño = "Sencillo";


        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("¡Bienvenido a la nevería!");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) Tipo de cono");
            System.Console.WriteLine("2) Sabor de nieve");
            System.Console.WriteLine("3) Tamaño");
            System.Console.WriteLine();
            System.Console.WriteLine("6) Pagar");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        {
            System.Console.WriteLine("¡Gracias por su preferencia! ¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        /*
        Selecciona un tipo de cono

        1) Regular
        2) Waffle

        9) Volver

        Selecciona una opción:
        */

        private void DisplaySelectConeMessage()
        {
            System.Console.WriteLine("Selecciona un tipo de cono");
            System.Console.WriteLine();
        }

        private void DisplaySelectConeOptions()
        {
            System.Console.WriteLine("1) Regular");
            System.Console.WriteLine("2) Waffle");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }


        private void DisplaySelectSizeMessage()
        {
            System.Console.WriteLine("Selecciona un tamaño");
            System.Console.WriteLine();
        }

        private void DisplaySelectSizeOptions()
        {
            System.Console.WriteLine("1) Regular");
            System.Console.WriteLine("2) Doble");
            System.Console.WriteLine("3) Triple");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }
        private void DisplaySelectFlavorMessage()
        {
            System.Console.WriteLine("Selecciona un sabor");
            System.Console.WriteLine();
        }

        private void DisplaySelectFlavorOptions()
        {
            System.Console.WriteLine("1) Chocolate");
            System.Console.WriteLine("2) Vainilla");
            System.Console.WriteLine("3) Fresa");
            System.Console.WriteLine("4) Limon");
            System.Console.WriteLine("5) Menta");
            System.Console.WriteLine("6) Galleta");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }

        private void SelectSize()
        {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplaySelectSizeMessage();
                DisplaySelectSizeOptions();
                System.Console.WriteLine($"Tamaño: {tamaño}");

                selectedOption = RequestOption(selectSizeOptions);

                switch (selectedOption)
                {
                    case 1:
                        tamaño = "Regular";
                        break;
                    case 2:
                        tamaño = "Doble";
                        break;
                    case 3:
                        tamaño = "Triple";
                        break;
                }
            }
        }

        private void SelectConeType()
        {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplaySelectConeMessage();
                DisplaySelectConeOptions();
                System.Console.WriteLine($"Tipo de Cono seleccionado: {tipoCono}");

                selectedOption = RequestOption(selectConeOptions);

                switch (selectedOption)
                {
                    case 1:
                        tipoCono = "Regular";
                        break;
                    case 2:
                        tipoCono = "Waffle";
                        break;
                }
            }
        }


        private void SelectFlavor()
        {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplaySelectFlavorMessage();
                DisplaySelectFlavorOptions();
                System.Console.WriteLine($"Sabor seleccionado: {sabor}");

                selectedOption = RequestOption(selectFlavorOptions);

                switch (selectedOption)
                {
                    case 1:
                        sabor = "Chocolate";
                        break;
                    case 2:
                        sabor = "Vainilla";
                        break;
                    case 3:
                        sabor = "Fresa";
                        break;
                    case 4:
                        sabor = "Limon";
                        break;
                    case 5:
                        sabor = "Menta";
                        break;
                    case 6:
                        sabor = "Galleta";
                        break;
                }
            }
        }


        private void Pay()
        {
            //\n es salto de línea
            System.Console.WriteLine("Tu pedido es el siguiente:\n");
            System.Console.WriteLine($"Cono: => {tipoCono}");
            System.Console.WriteLine($"sabor de helado: => {sabor}");
            System.Console.WriteLine($"Tamaño: => {tamaño}");
            System.Console.WriteLine("\n!Gracias por tu compra!");
        }

        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        SelectConeType();
                        break;

                    case 2:
                        SelectFlavor();
                        break;

                    case 3:
                        SelectSize();
                        break;

                    case 6:
                        Pay();
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;

                }
            }

            DisplayByeMessage();

        }

    }
}