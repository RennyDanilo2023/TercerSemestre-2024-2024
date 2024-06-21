class Contribution:
    def __init__(self, member_name, amount, date):
        self.member_name = member_name
        self.amount = amount
        self.date = date

    def __repr__(self):
        return f"Contribution(member_name={self.member_name}, amount={self.amount}, date={self.date})"

class ContributionRegistry:
    def __init__(self):
        self.contributions = []

    def add_contribution(self):
        member_name = input("Ingrese el nombre del miembro: ")
        amount = float(input("Ingrese el monto del aporte: "))
        date = input("Ingrese la fecha del aporte: ")
        new_contribution = Contribution(member_name, amount, date)
        self.contributions.append(new_contribution)
        print(f"Aporte de {member_name} añadido exitosamente.")

    def find_contribution(self):
        member_name = input("Ingrese el nombre del miembro para buscar el aporte: ")
        for contribution in self.contributions:
            if contribution.member_name.lower() == member_name.lower():
                print(contribution)
                return contribution
        print(f"Aporte de {member_name} no encontrado.")
        return None

    def delete_contribution(self):
        contribution = self.find_contribution()
        if contribution:
            self.contributions.remove(contribution)
            print(f"Aporte de {contribution.member_name} eliminado exitosamente.")

    def update_contribution(self):
        contribution = self.find_contribution()
        if contribution:
            amount = input("Ingrese el nuevo monto del aporte (dejar en blanco para no cambiar): ")
            date = input("Ingrese la nueva fecha del aporte (dejar en blanco para no cambiar): ")
            if amount:
                contribution.amount = float(amount)
            if date:
                contribution.date = date
            print(f"Aporte de {contribution.member_name} actualizado exitosamente.")

    def display_contributions(self):
        if self.contributions:
            for contribution in self.contributions:
                print(contribution)
        else:
            print("No se encontraron aportes.")

# Ejemplo de uso
contribution_registry = ContributionRegistry()
while True:
    print("\nRegistro de Aportes")
    print("1. Añadir aporte")
    print("2. Buscar aporte")
    print("3. Eliminar aporte")
    print("4. Actualizar aporte")
    print("5. Mostrar todos los aportes")
    print("6. Salir")
    
    choice = input("Seleccione una opción: ")
    
    if choice == "1":
        contribution_registry.add_contribution()
    elif choice == "2":
        contribution_registry.find_contribution()
    elif choice == "3":
        contribution_registry.delete_contribution()
    elif choice == "4":
        contribution_registry.update_contribution()
    elif choice == "5":
        contribution_registry.display_contributions()
    elif choice == "6":
        break
    else:
        print("Opción no válida, intente de nuevo.")
