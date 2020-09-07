using System;
using System.Text;
/*el codigo original no cumple con el SRP
debido a que todo el programa tenia la responsabilidad de crear los objetos pacientes,
crear los objetos medicos y crear las consultas. Dividiendo el programa en 3 clases distintas
y haciendo que cada una tenga la responsabilidad que le compete se logra cumplir el principio 
de SRP.
*/
namespace Library
{
    private static int codigo_consulta;
    public codigo_consulta()
    {
        codigo_consulta++;
        this.Codigo_consulta=codigo_consulta;
    }
    public class AppointmentService
    {
        public static string CreateAppointment(Paciente paciente, Doctor doctor, string consultorio)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (Paciente.Validar_Paciente(paciente))
            {
                return false;
            }
            if (Doctor.Validar_Doctor(doctor))
            {
                return false;
            }
            if (!string.IsNullOrEmpty(consultorio))
            {
                this.Consultorio=consultorio;
            }
            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
            return stringBuilder.ToString();
        }

    }
}
