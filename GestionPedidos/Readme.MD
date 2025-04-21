# Sistema de Pedidos

Este proyecto es una aplicación de consola desarrollada en **C#** que implementa el patrón de diseño **MVC** (Modelo-Vista-Controlador). El sistema permite gestionar pedidos, productos y clientes, proporcionando una estructura clara y modular para la interacción entre los componentes.

---

## 📁 Estructura del Proyecto

El proyecto está organizado en tres capas principales según el patrón **MVC**:

### 1. Modelos (`Models`)

Los modelos representan los datos y la lógica de negocio del sistema. En este proyecto, los modelos incluyen:

- **Product**: Representa un producto con propiedades como `Name`, `Price` y `Desc`. Incluye el método `FinalPrice()` para calcular el precio final del producto.
- **Client**: Representa un cliente con información como `Name`, `LastName`, `ID`, `Adress` y `Email`.
- **Order**: Representa un pedido que contiene una lista de productos y un cliente asociado. Proporciona métodos para calcular el total del pedido con y sin IVA.

### 2. Vistas (`Views`)

Las vistas se encargan de interactuar con el usuario, capturando entradas y mostrando resultados. Incluyen:

- **ProductView**: Permite al usuario cargar información de un producto.
- **ClientView**: Permite al usuario capturar información de un cliente.
- **OrderView**: Proporciona un menú para gestionar pedidos, como agregar productos, asignar clientes y mostrar totales.

### 3. Controladores (`Controllers`)

Los controladores manejan la lógica de la aplicación y actúan como intermediarios entre modelos y vistas. Incluyen:

- **ProductController**: Gestiona la lógica relacionada con los productos.
- **ClientController**: Gestiona la lógica relacionada con los clientes.
- **OrderController**: Gestiona la lógica relacionada con los pedidos.

---

## 🔄 Flujo de la Aplicación

1. **Inicio**: La aplicación comienza en el archivo `Program.cs`, donde se inicializa la vista principal (`OrderView`) y se muestra un menú interactivo.
2. **Interacción del Usuario**: El usuario selecciona opciones del menú para realizar acciones como:
   - Agregar productos a un pedido.
   - Asignar un cliente a un pedido.
   - Calcular y mostrar el total del pedido con o sin IVA.
3. **Controladores**: Procesan las solicitudes recibidas desde las vistas, actualizando los modelos según sea necesario.
4. **Modelos**: Almacenan y procesan los datos, devolviendo los resultados a los controladores.
5. **Vistas**: Muestran los resultados al usuario y capturan nuevas entradas.

---

## 🧪 Ejemplo de Uso

1. El usuario selecciona la opción **"Agregar Producto"** en el menú.
2. La vista `ProductView` solicita al usuario que ingrese los datos del producto.
3. El controlador `ProductController` procesa los datos y los agrega al modelo `Order`.
4. El usuario puede ver el total del pedido con o sin IVA utilizando las opciones del menú.

---
