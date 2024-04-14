string nombre = "", apellido="", titulo = "BANCO Baning", men, nocuentain, depo, repdep, cuentain = "", reti="",cheque1;
double  cont = 0, menu = 0, contanom = 0, contaap = 0, cuenta = 0, siono = 0,cdep=0,saldo=0, cret =0;
string[] cuentapersonal = new string[9];
bool Esnum = false;
string[] numcheque = new string[40];
int Contador_de_retiros = 0, Retiro_actual = 0;
int depexitosos = 0, depositosfallidos = 0, retirosexitosos = 0, retirosfallidos = 0, error = 0, error2 = 0, err=0, numero_de_cheque;
Random rnd = new Random();
do
{
    Console.Clear();
    do
    {
        men = "";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
        Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White;
        if (cuenta == 0)
        {
            Console.WriteLine("1. Crear Cuenta");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; Console.WriteLine("1. Crear Cuenta (Ya creada)"); Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("2. Realizar Depósito");
        Console.WriteLine("3. Realizar Retiro");
        Console.WriteLine("4. Estadísticas");
        Console.WriteLine("5. Salir");
        Console.Write("Ingrese un número: "); men = Console.ReadLine();
        if (men == "")
        {
            Console.BackgroundColor = ConsoleColor.Red;  Console.WriteLine("Ingrese un dato válido \nDele enter para continuar"); Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            for (int i = 0; i < men.Length; i++)
            {
                if ((men[i] < '0') || (men[i] > '9') || men == "")
                {
                    error = 1;
                }
                else
                {
                    Esnum = true;
                }

            }
            if (error == 1)
            {
                error = 0;
            }
            else
            {
                menu = Convert.ToDouble(men);
            }
        }

    }while(!Esnum);
    switch (menu)
    {
        case 1:
            if(cuenta == 1)
            {
                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("Ya ha creado con éxito una cuenta \nDele enter para continuar");
                Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                Console.Clear();
                Esnum = false;
            }
            else
            {
                do
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
                        Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bienvenido al Banco Baning, para crear su cuenta ingrese: ");
                        Console.Write("Su primer nombre: "); nombre = Console.ReadLine();
                        for (int j = 0; j < nombre.Length; j++)
                        {
                            if ((nombre[j] < '0') || (nombre[j] > '9'))
                            {
                                contanom = 1;
                            }
                            else
                            {
                                contanom = 0;
                            }

                        }
                        if (nombre == "")
                        {
                            contanom = 0;
                        }
                        else if (contanom == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese datos válidos \n" + "Dele enter para continuar");
                            Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                            Console.Clear();
                        }

                    } while (contanom == 0);
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
                        Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bienvenido al Banco Baning, para crear su cuenta ingrese: ");
                        Console.WriteLine("Su primer nombre: " + nombre);
                        Console.Write("Su primer apellido: "); apellido = Console.ReadLine();
                        for (int k = 0; k < apellido.Length; k++)
                        {
                            if ((apellido[k] < '0') || (apellido[k] > '9'))
                            {
                                contaap = 1;
                            }
                            else
                            {
                                contaap = 0;
                            }
                        }
                        if (apellido == "")
                        {
                            contaap = 0;
                        }
                        else if(contaap == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese datos válidos \n" + "Dele enter para continuar");
                            Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                            Console.Clear();
                        }
                    } while (contaap == 0);
                    do
                    {
                        Console.Write("Debe realizar un primer depósito mayor o igual a Q200.00 para activar su cuenta: Q.");  depo = Console.ReadLine();
                        if(depo != "")
                        {
                            for (int depos = 0; depos < depo.Length; depos++)
                            {
                                if((depo[depos] < '0') || (depo[depos] > '9'))
                                {
                                    Esnum = false;
                                    error++;
                                }
                                else
                                {
                                    Esnum = true;
                                }
                            }
                            if (Esnum && error ==0)
                            {
                                Esnum = false;
                                saldo = Convert.ToDouble(depo);
                                    if (saldo < 200)
                                    {
                                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Debe realizar un depósito mayor o igual a Q200");
                                    Console.BackgroundColor = ConsoleColor.Black; cont = 0;
                                    }
                                    else
                                    {
                                        cont = 2;
                                    }
                                }
                                else
                                {
                                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese datos válidos "); Console.BackgroundColor = ConsoleColor.Black;
                                error = 0;
                                }   
                        }

                    } while (cont == 0);
                    Console.WriteLine("Su número de cuenta es: ");
                    for (int l = 0;l< 9; l++)
                    {
                        cuentapersonal[l] = Convert.ToString(rnd.Next(0, 9));
                        Console.Write(cuentapersonal[l]);
                    }
                    cuenta = 1;
                    Console.WriteLine("\nDele enter para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Esnum = false;
                    cont = 2;
                } while (cont != 2);
            }
            break;
        case 2:
            contaap = 0;
            if(cuenta == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("No tiene número de cuenta, por lo que no puede hacer depósitos aún. \nDele Enter para continuar");
                Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                Console.Clear ();
                Esnum = false;
            }
            else
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
                    Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;Console.Write("Bienvenido al apartado de depósitos: \nIngrese su número de cuenta: "); nocuentain = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black; for (int m = 0; m < nocuentain.Length; m++)
                    {
                        if ((nocuentain[m] < '0') || (nocuentain[m] > '9')|| nocuentain== "")
                        {
                            contaap = 0;
                            error = 1;
                        }
                        else
                        {
                            contaap = 1;
                        }

                    }

                    if(contaap != 0)
                    {
                        for (int n = 0;n < nocuentain.Length; n++)
                        {
                            for(int o = 0; o< nocuentain.Length; o++)
                            {
                                cuentain = nocuentain[o].ToString();
                                if (cuentain == (cuentapersonal[n]))
                                {
                                    Esnum = true;
                                }
                                else
                                {
                                    error = 1;
                                    Esnum = false;
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El valor ingresado es inválido");
                        Console.BackgroundColor = ConsoleColor.Black; error = 1;
                    }
                    if (Esnum && contaap == 1)
                         {
                        Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("Ha ingresado con éxito a su cuenta: " + nombre); Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("El monto mínimo de un depósito son Q50.00\nEscriba la cantidad que desea depositar: Q."); depo = Console.ReadLine();
                            for (int p = 0; p < depo.Length; p++)
                            {
                                if ((depo[p] < '0') || (depo[p] > '9') || depo == "")
                                {
                                    contaap = 0;
                                }
                                else
                                {
                                    contaap = 1;
                                }

                            }
                            if(contaap == 1)
                            {
                                cdep = Int32.Parse(depo);
                                if (cdep < 50)
                                {
                                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El monto mínimo es de Q50.00");
                                Console.BackgroundColor = ConsoleColor.Black; error = 1;
                                }
                                else
                                {
                                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("El depósito se ha realizado con éxito, el saldo de la cuenta se ha actualizado");
                                Console.BackgroundColor = ConsoleColor.Black; Console.WriteLine("¿Desea realizar otro depósito??");
                                    error = 0;
                                    saldo = saldo + cdep;
                                    depexitosos++;
                                }
                            }
                         }
                        if (error != 0)
                        {
                            error = 0;
                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Se ha detectado un error al ingresar datos válidos");Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Se tomará como depósito fallido \nDesea Realizar otro depósito?"); Console.BackgroundColor = ConsoleColor.Black;
                        depositosfallidos++;
                        }
                    if (error == 0)
                    {
                        do
                        {
                            Console.Write("Escriba S para Sí y N para No: "); repdep = Console.ReadLine();
                            repdep.ToLower();
                            if (repdep == "s")
                            {
                                Esnum = false;
                                siono = 1;
                            }
                            else if (repdep == "n")
                            {
                                Esnum = true;
                                siono = 1;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese una opción verdadera");
                                Console.BackgroundColor = ConsoleColor.Black; siono = 0;
                            }
                        } while (siono == 0);
                    }
                } while (!Esnum);
            }
            Esnum = false;
            break;
        case 3:
            contaap = 0;
            if (cuenta == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("No tiene número de cuenta, por lo que no puede hacer retiros aún. \nDele Enter para continuar");
                Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                Console.Clear();
                Esnum = false;
            }
            else
            {
                do
                {
                    Esnum = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
                    Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write("Bienvenido al apartado de retiros: \nIngrese su número de cuenta: "); nocuentain = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black; for (int q = 0; q < nocuentain.Length; q++)
                    {
                        if ((nocuentain[q] < '0') || (nocuentain[q] > '9') || nocuentain == "")
                        {
                            contaap = 0;
                            error = 1;
                        }
                        else
                        {
                            contaap = 1;
                        }

                    }

                    if (contaap != 0)
                    {
                        for (int r = 0; r < nocuentain.Length; r++)
                        {
                            for (int s = 0; s < nocuentain.Length; s++)
                            {
                                cuentain = nocuentain[s].ToString();
                                if (cuentain == (cuentapersonal[r]))
                                {
                                    Esnum = true;
                                }
                                else
                                {
                                    error = 1;
                                    Esnum = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El valor ingresado es inválido"); Console.BackgroundColor = ConsoleColor.Black;
                        error = 1;
                    }
                    if (Esnum && contaap == 1)
                    {
                        string  chequestring;
                        int cheque;
                        Contador_de_retiros++;
                        if(Contador_de_retiros > 40)
                        {
                            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ha sobrepasado los 40 depósitos diarios " + nombre); Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("Ha ingresado con éxito a su cuenta: " + nombre); Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("Ingrese el número de su cheque: "); chequestring = Console.ReadLine();
                            
                            if (chequestring.Length != 5)
                            {
                                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El número de cheque debe de ser de 5 dígitos");
                                Console.BackgroundColor = ConsoleColor.Black; error = 1;
                            }
                            else
                            {
                                for (int ch = 0; ch < 5; ch++)
                                {
                                    if ((chequestring[ch] < '0') || (chequestring[ch] > '9') || chequestring == "")
                                    {
                                        contaap = 0;
                                    }
                                    else
                                    {
                                        contaap = 1;
                                    }

                            }
                                if (contaap == 0)
                                {
                                    Esnum = false;
                                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese un número de cheque válido"); Console.BackgroundColor = ConsoleColor.Black;
                                }
                                if(contaap != 0)
                                {
                                    cheque = Convert.ToInt32(chequestring);
                                    numcheque[Retiro_actual] = chequestring;
                                    Retiro_actual++;
                                    if (Retiro_actual == 1)
                                    {
                                        error2 = 1;
                                    }
                                    else
                                    {
                                        error2 = 0;
                                        for (int hc = 0; hc < Retiro_actual - 1; hc++)
                                        {                                            error2 = 0;
                                            numero_de_cheque = Convert.ToInt32(numcheque[hc]);
                                            Console.WriteLine(cheque +" " + numcheque[hc]);
                                            if ( cheque == numero_de_cheque)
                                            {
                                                err++;
                                            }
                                            else
                                            {
                                                error = 0;
                                                error2++;
                                            }
                                        }
                                    }
                                    if (err != 0)
                                    {
                                        err = 0;
                                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El número de cheque ya fue ingresado"); Console.BackgroundColor = ConsoleColor.Black;
                                        error = 1;
                                        contaap = 0;
                                    }
                                    if ((error2 != 0 && error != 1) || (Retiro_actual == 1 && err == 0))
                                    {
                                        err = 0;
                                        contaap = 0;
                                        Console.Write("El monto mínimo de un retiro es de Q50.00\nEscriba la cantidad que desea retirar: Q."); reti = Console.ReadLine();
                                        for (int t = 0; t < reti.Length; t++)
                                        {
                                            if ((reti[t] < '0') || (reti[t] > '9') || reti == "")
                                            {
                                                contaap = 0;
                                            }
                                            else
                                            {
                                                contaap = 1;
                                            }

                                        }
                                    }
                                }
                                if (contaap == 1)
                                {
                                    cret = Int32.Parse(reti);
                                    if (cret < 50)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El monto mínimo es de Q50.00"); Console.BackgroundColor = ConsoleColor.Black;
                                        error = 1;
                                    }
                                    else
                                    {
                                        if (cret > saldo)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("La cantidad a retirar supera el saldo actual de la cuenta ");
                                            Console.WriteLine("Se ha producido un retiro fallido, Se le descontarán Q.150.00 de su cuenta");
                                            Console.BackgroundColor = ConsoleColor.Black; saldo = saldo - 150;
                                            error = 1;
                                        }
                                        else
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("El retiro fue realizado con éxito, el saldo se ha actualizado\n¿Desea Realizar otro retiro?");
                                            Console.BackgroundColor = ConsoleColor.Black; retirosexitosos++;
                                            saldo = saldo - cret;
                                            error = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (error == 1)
                        {
                            error = 0;
                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Se ha detectado un error al ingresar datos válidos");
                            Console.WriteLine("Se tomará como retiro fallido \n¿Desea Realizar otro depósito?"); Console.BackgroundColor = ConsoleColor.Black;
                        retirosfallidos++;
                        }
                        do
                        {
                            Console.Write("Escriba S para Sí y N para No: "); repdep = Console.ReadLine();
                            if (repdep.ToLower() == "s")
                            {
                                Esnum = false;
                                siono = 1;
                            }
                            else if (repdep.ToLower() == "n")
                            {
                                Esnum = true;
                                siono = 1;
                            }
                            else
                            {
                            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese una opción verdadera"); Console.BackgroundColor = ConsoleColor.Black;
                            siono = 0;
                            }
                        } while (siono == 0);

                    

                } while (!Esnum);
            }
            Esnum = false;
            break;
        case 4:
            if (cuenta == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("No tiene una cuenta, no puede acceder a estadísticas \nDele Enter para continuar");
                Console.BackgroundColor = ConsoleColor.Black; Console.ReadLine(); 
                Esnum = true;
            }
            else
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.Write(new string(' ', (Console.WindowWidth - titulo.Length) / 2));
                    Console.WriteLine("BANCO Baning"); Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write("Bienvenido al apartado de Estadisticas \nIngrese su número de cuenta: "); nocuentain = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black; for (int es = 0; es < nocuentain.Length; es++)
                    {
                        if ((nocuentain[es] < '0') || (nocuentain[es] > '9') || nocuentain == "")
                        {
                            contaap = 0;
                        }
                        else
                        {
                            contaap = 1;
                        }
                    }

                    if (contaap != 0)
                    {
                        for (int estat = 0; estat < nocuentain.Length; estat++)
                        {
                            for (int es = 0; es < nocuentain.Length; es++)
                            {
                                cuentain = nocuentain[es].ToString();
                                if (cuentain == (cuentapersonal[es]))
                                {
                                    Esnum = true;
                                }
                                else
                                {
                                    error = 1;
                                    Esnum = false;
                                }
                            }
                        }
                    }
                    if(!Esnum)
                    {
                        Console.WriteLine(nocuentain); Console.WriteLine(cuentain);Console.WriteLine(cuentapersonal);
                        Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("El número de cuenta ingresado no existe\nSerá regresado al menú principal, dele enter para continuar");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ReadKey();
                    }else
                    {
                        if (depositosfallidos == 0)
                        {
                            Console.WriteLine("No ha tenido depósitos fallidos");
                        }
                        else
                        {
                            if (depositosfallidos >= 0 && depositosfallidos < 10)
                            {
                                Console.Write("Los depósitos fallidos han sido:     " + depositosfallidos + "| ");
                            }
                            else if (depositosfallidos > 10 && depositosfallidos < 100)
                            {
                                Console.Write("Los depósitos fallidos han sido:    " + depositosfallidos + "| ");
                            }else if (depositosfallidos > 100 && depositosfallidos < 1000)
                            {
                                Console.Write("Los depósitos fallidos han sido:   " + depositosfallidos + "| ");
                            }
                            for (int de = 0; de < depositosfallidos; de++)
                            {
                                Console.Write("█");
                            }
                            Console.WriteLine("");
                        }
                        if (depexitosos == 0)
                        {
                            Console.WriteLine("No ha tenido depósitos exitosos");
                        }
                        else
                        {
                            if (depexitosos >= 0&&depexitosos <100)
                            {
                                Console.Write("Los depósitos exitosos han sido:     " + depexitosos + "| ");
                            }else if (depexitosos > 99 && depexitosos < 1000)
                            {
                                Console.Write("Los depósitos exitosos han sido:    " + depexitosos + "| ");
                            }
                            else if (depexitosos > 100 && depexitosos < 1000)
                            {
                                Console.Write("Los depósitos exitosos han sido:   " + depositosfallidos + "| ");
                            }
                            for (int de = 0; de < depexitosos; de++)
                            {
                                Console.Write("█");
                            }
                            Console.WriteLine("");
                        }
                        if (retirosfallidos == 0)
                        {
                            Console.WriteLine("No ha tenido retiros fallidos");
                        }
                        else
                        {
                            if (retirosfallidos >= 0 && retirosfallidos < 100)
                            {
                                Console.Write("Los retiros fallidos han sido:     " + retirosfallidos + "| ");
                            }
                            else if (retirosfallidos > 99 && retirosfallidos < 1000)
                            {
                                Console.Write("Los retiros fallidos han sido:    " + retirosfallidos + "| ");
                            }
                            else if (retirosfallidos > 100 && retirosfallidos < 1000)
                            {
                                Console.Write("Los retiros fallidos han sido:   " + depositosfallidos + "| ");
                            }
                            for (int de = 0; de < retirosfallidos; de++)
                            {
                              Console.Write("█"); 
                            }
                            Console.WriteLine("");
                        }
                        if (retirosexitosos == 0)
                        {
                            Console.WriteLine("No ha tenido retiros exitosos");
                            Console.WriteLine("\nEsos han sido los datos estadisticos de la cuenta a nombre de " + nombre + " " + apellido + "\nDele enter para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (retirosexitosos >= 0 && retirosexitosos < 100)
                            {
                                Console.Write("Los retiros exitosos han sido:     " + retirosexitosos + "| ");
                            }
                            else if (retirosexitosos > 99 && retirosexitosos < 1000)
                            {
                                Console.Write("Los retiros exitosos han sido:    " + retirosexitosos + "| ");
                            }
                            else if (retirosexitosos > 100 && retirosexitosos < 1000)
                            {
                                Console.Write("Los retiros fallidos han sido:   " + retirosexitosos + "| ");
                            }
                            for (int de = 0; de < retirosexitosos; de++)
                            {
                                Console.Write("█");
                            }
                            Console.WriteLine("\nEsos han sido los datos estadisticos de la cuenta a nombre de "+nombre +" " + apellido+"\nDele enter para continuar");
                            Console.ReadKey();
                        }
                    }
                    
                    Esnum = true;
            }while (!Esnum);
        }
            Esnum = false;
            break;
        case 5:
            Esnum = true;
            Console.WriteLine("Diego Alejandro Ovalle Pedroza, carnet: 150024\nAdrián Fabricio Matul Racancoj, carnet: 1509224\nDele enter para salir");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Ingrese un dato válido\nDele enter para continuar");
            Console.ReadKey();
            Esnum = false;
            break;
    }           
} while (!Esnum);