utilizando  System ;
espacio de nombres  Practica2
{
  público  de clase  Reloj
	{	
		privadas  int  Horas ;
		privadas  int  minutes ;
		privadas  int  seconds ;
		privadas  Utilerias  utilerias ;

		público  Reloj  ()
		{
			este . Horas  =  0 ;
			esto . Minutos  =  0 ;
			esto . seconds  =  0 ;
			esto . utilerias  =  nuevo  Utilerias ();
		}

		público  vacío  INICIAR () {
			este . obtenHoraLocal ();
			este . iniciaProceso ();
		}

		privado  vacío  obtenHoraLocal () {
			esto . Horas  =  DateTime . Ahora . horas ;
			esto . Minutos  =  DateTime . Ahora . Minute ;
			esto . seconds  =  DateTime . Ahora . Segundo ;
		}

		privado  vacío  iniciaProceso () {
			este . utilerias . limpiaPantalla ();
			mientras que ( verdad ) {
				para ( esto . Horas  =  esto . Horas ,  este . HORAS  <  24 ;  este . Horas + +) {
					para ( esto . Minutos  =  esto . Minutos ;  esto . Minutos  <  60 ;  éste . Minutos + +) {
						para ( esto . Segundos  =  esto . seconds ;  esto . Segundos  <  60 ;  éste . Segundos + +) {
							esto . utilerias . imprimeTiempoActual ( este . Horas ,  este . Minutos ,  este . Segundos );
							este . utilerias . duerme1Segundo ();
							este . utilerias . limpiaPantalla ();
						}
						esto . seconds  =  0 ;
					}
					esto . Minutos  =  0 ;	
				}
				este . reiniciarDia ();

			}
		}

		privado  vacío  reiniciarDia () {
			este . Horas  =  0 ;
			esto . Minutos  =  0 ;
			esto . seconds  =  0 ;
		}
	}
}
