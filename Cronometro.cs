using System;
namespace Practica2
{
	public class Cronometro
	{
		private int horas;
		private int minutos;
		private int segundos;
		private Utilerias utilerias;

		public Cronometro ()
		{
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
			this.utilerias = new Utilerias();
		}

		public void iniciar(){
			this.iniciaProceso();			
		}

		private void iniciaProceso(){
			this.utilerias.limpiaPantalla();
			for(this.horas = 0; this.horas < 1000; this.horas++){
				for(this.minutos = 0; this.minutos < 60; this.minutos++){
					for(this.segundos = 0; this.segundos < 60; this.segundos++){
						this.utilerias.imprimeTiempoActual(this.horas, this.minutos, this.segundos);
						this.utilerias.duerme1Segundo();
						this.utilerias.limpiaPantalla();
					}
				}
			}

		}

	}
}
