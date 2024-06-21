class Appointment:
    def __init__(self, patient_name, doctor_name, time, date):
        self.patient_name = patient_name
        self.doctor_name = doctor_name
        self.time = time
        self.date = date

    def __repr__(self):
        return f"Appointment(patient_name={self.patient_name}, doctor_name={self.doctor_name}, time={self.time}, date={self.date})"

class ClinicSchedule:
    def __init__(self):
        self.appointments = []

    def add_appointment(self):
        patient_name = input("Ingrese el nombre del paciente: ")
        doctor_name = input("Ingrese el nombre del doctor: ")
        time = input("Ingrese la hora de la cita: ")
        date = input("Ingrese la fecha de la cita: ")
        new_appointment = Appointment(patient_name, doctor_name, time, date)
        self.appointments.append(new_appointment)
        print(f"Cita para {patient_name} añadida exitosamente.")

    def find_appointment(self):
        patient_name = input("Ingrese el nombre del paciente para buscar la cita: ")
        for appointment in self.appointments:
            if appointment.patient_name.lower() == patient_name.lower():
                print(appointment)
                return appointment
        print(f"Cita para {patient_name} no encontrada.")
        return None

    def delete_appointment(self):
        appointment = self.find_appointment()
        if appointment:
            self.appointments.remove(appointment)
            print(f"Cita para {appointment.patient_name} eliminada exitosamente.")

    def update_appointment(self):
        appointment = self.find_appointment()
        if appointment:
            doctor_name = input("Ingrese el nuevo nombre del doctor (dejar en blanco para no cambiar): ")
            time = input("Ingrese la nueva hora de la cita (dejar en blanco para no cambiar): ")
            date = input("Ingrese la nueva fecha de la cita (dejar en blanco para no cambiar): ")
            if doctor_name:
                appointment.doctor_name = doctor_name
            if time:
                appointment.time = time
            if date:
                appointment.date = date
            print(f"Cita para {appointment.patient_name} actualizada exitosamente.")

    def display_appointments(self):
        if self.appointments:
            for appointment in self.appointments:
                print(appointment)
        else:
            print("No se encontraron citas.")

# Ejemplo de uso
clinic_schedule = ClinicSchedule()
while True:
    print("\nAgenda de Turnos de Pacientes")
    print("1. Añadir cita")
    print("2. Buscar cita")
    print("3. Eliminar cita")
    print("4. Actualizar cita")
    print("5. Mostrar todas las citas")
    print("6. Salir")
    
    choice = input("Seleccione una opción: ")
    
    if choice == "1":
        clinic_schedule.add_appointment()
    elif choice == "2":
        clinic_schedule.find_appointment()
    elif choice == "3":
        clinic_schedule.delete_appointment()
    elif choice == "4":
        clinic_schedule.update_appointment()
    elif choice == "5":
        clinic_schedule.display_appointments()
    elif choice == "6":
        break
    else:
        print("Opción no válida, intente de nuevo.")
