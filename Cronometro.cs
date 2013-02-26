utilizando  System ;
espacio de nombres  Practica2
{
  público  de clase  Cronometro
	{
		privadas  int  Horas ;
		privadas  int  minutes ;
		privadas  int  seconds ;
		privadas  Utilerias  utilerias ;

		público  Cronometro  ()
		{
			este . Horas  =  0 ;
			esto . Minutos  =  0 ;
			esto . seconds  =  0 ;
			esto . utilerias  =  nuevo  Utilerias ();
		}

		público  vacío  INICIAR () {
			este . iniciaProceso ();			
		}

		privado  vacío  iniciaProceso () {
			este . utilerias . limpiaPantalla ();
			para ( esto . Horas  =  0 ;  este . Horas  <  1,000 ;  este . Horas + +) {
				para ( esto . Minutos  =  0 ;  éste . Minutos  <  60 ;  éste . Minutos + +) {
					para ( esto . seconds  =  0 ;  éste . Segundos  <  60 ;  éste . Segundos + +) {
						esto . utilerias . imprimeTiempoActual ( este . Horas ,  este . Minutos ,  este . Segundos );
						este . utilerias . duerme1Segundo ();
						este . utilerias . limpiaPantalla ();
					}
				}
			}

		}

	}
}
