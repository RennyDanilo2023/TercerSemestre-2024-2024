class Contact:
    def __init__(self, name, phone, email):
        self.name = name
        self.phone = phone
        self.email = email

    def __repr__(self):
        return f"Contact(name={self.name}, phone={self.phone}, email={self.email})"

class PhoneBook:
    def __init__(self):
        self.contacts = []

    def add_contact(self):
        name = input("Ingrese el nombre: ")
        phone = input("Ingrese el teléfono: ")
        email = input("Ingrese el correo electrónico: ")
        new_contact = Contact(name, phone, email)
        self.contacts.append(new_contact)
        print(f"Contacto {name} añadido exitosamente.")

    def find_contact(self):
        name = input("Ingrese el nombre del contacto a buscar: ")
        for contact in self.contacts:
            if contact.name.lower() == name.lower():
                print(contact)
                return contact
        print(f"Contacto {name} no encontrado.")
        return None

    def delete_contact(self):
        contact = self.find_contact()
        if contact:
            self.contacts.remove(contact)
            print(f"Contacto {contact.name} eliminado exitosamente.")

    def update_contact(self):
        contact = self.find_contact()
        if contact:
            phone = input("Ingrese el nuevo teléfono (dejar en blanco para no cambiar): ")
            email = input("Ingrese el nuevo correo electrónico (dejar en blanco para no cambiar): ")
            if phone:
                contact.phone = phone
            if email:
                contact.email = email
            print(f"Contacto {contact.name} actualizado exitosamente.")

    def display_contacts(self):
        if self.contacts:
            for contact in self.contacts:
                print(contact)
        else:
            print("No se encontraron contactos.")

# Ejemplo de uso
phone_book = PhoneBook()
while True:
    print("\nAgenda Telefónica")
    print("1. Añadir contacto")
    print("2. Buscar contacto")
    print("3. Eliminar contacto")
    print("4. Actualizar contacto")
    print("5. Mostrar todos los contactos")
    print("6. Salir")
    
    choice = input("Seleccione una opción: ")
    
    if choice == "1":
        phone_book.add_contact()
    elif choice == "2":
        phone_book.find_contact()
    elif choice == "3":
        phone_book.delete_contact()
    elif choice == "4":
        phone_book.update_contact()
    elif choice == "5":
        phone_book.display_contacts()
    elif choice == "6":
        break
    else:
        print("Opción no válida, intente de nuevo.")
