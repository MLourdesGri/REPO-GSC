// Ejercicio 1
let nombre: string = "Lourdes";
let edad: number = 22;
let esEstudiante: boolean = true;

console.log("Nombre:", nombre);
console.log("Edad:", edad);
console.log("¿Es estudiante?:", esEstudiante);

// Ejercicio 2
function sumar(a: number, b: number): number {
    return a + b;
}

function restar(a: number, b: number): number {
    return a - b;
}

function multiplicar(a: number, b: number): number {
    return a * b;
}

console.log("Suma:", sumar(5, 3));
console.log("Resta:", restar(5, 3));
console.log("Multiplicación:", multiplicar(5, 3));

// Ejercicio 3
let numeros: number[] = [1, 2, 3, 4, 5];
numeros.forEach(numero => console.log(numero * 2));

// Ejercicio 4
interface Persona {
    nombre: string;
    edad: number;
    esEstudiante: boolean;
}

const persona1: Persona = { nombre: "Ana", edad: 22, esEstudiante: true };
const persona2: Persona = { nombre: "Luis", edad: 30, esEstudiante: false };
const persona3: Persona = { nombre: "Marta", edad: 25, esEstudiante: true };

console.log(persona1);
console.log(persona2);
console.log(persona3);

// Ejercicio 5
let variable: string | number;
variable = "Hola";
console.log("Variable como string:", variable);
variable = 42;
console.log("Variable como number:", variable);

// Ejercicio 6
interface Producto {
    nombre: string;
    precio: number;
    enStock: boolean;
}

const productos: Producto[] = [
    { nombre: "Laptop", precio: 1500, enStock: true },
    { nombre: "Teclado", precio: 100, enStock: false },
    { nombre: "Mouse", precio: 50, enStock: true },
    { nombre: "Monitor", precio: 300, enStock: false },
    { nombre: "Cargador", precio: 25, enStock: true },
    { nombre: "Audífonos", precio: 80, enStock: false }
];

function productosEnStock(productos: Producto[]): Producto[] {
    return productos.filter(producto => producto.enStock);
}

function productosSinStock(productos: Producto[]): Producto[] {
    return productos.filter(producto => !producto.enStock);
}

console.log("Productos en stock:", productosEnStock(productos));
console.log("Productos sin stock:", productosSinStock(productos));

// Ejercicio 7
interface Cliente {
    nombre: string;
    edad: number;
    esEstudiante: boolean;
    ciudad: string;
}

const clientes: Cliente[] = [
    { nombre: "Carlos", edad: 28, esEstudiante: true, ciudad: "Madrid" },
    { nombre: "María", edad: 34, esEstudiante: false, ciudad: "Barcelona" },
    { nombre: "Juan", edad: 22, esEstudiante: true, ciudad: "Valencia" },
    { nombre: "Luisa", edad: 40, esEstudiante: false, ciudad: "Sevilla" },
    { nombre: "Pedro", edad: 29, esEstudiante: true, ciudad: "Granada" },
    { nombre: "Sofía", edad: 26, esEstudiante: false, ciudad: "Bilbao" }
];

function clientesEstudiante(clientes: Cliente[]): Cliente[] {
    return clientes.filter(cliente => cliente.esEstudiante);
}

function clientesNoEstudiante(clientes: Cliente[]): Cliente[] {
    return clientes.filter(cliente => !cliente.esEstudiante);
}

console.log("Clientes estudiante:", clientesEstudiante(clientes));
console.log("Clientes no estudiante:", clientesNoEstudiante(clientes));

// Ejercicio 8: Catálogo de Productos - forEach
const catalogo = [
    { nombre: "Producto A", precio: 30 },
    { nombre: "Producto B", precio: 60 },
    { nombre: "Producto C", precio: 20 }
];

catalogo.forEach(producto => {
    console.log(`Nombre: ${producto.nombre}, Precio: $${producto.precio}`);
});

// Ejercicio 9: Catálogo de Productos - filter
const productosBaratos = catalogo.filter(producto => producto.precio < 50);
console.log("Productos baratos:", productosBaratos);

// Ejercicio 10: Actualización de Inventario - map
const catalogoConDescuento = catalogo.map(producto => ({
    ...producto,
    precio: producto.precio * 0.9
}));
console.log("Catálogo con descuento:", catalogoConDescuento);

// Ejercicio 11: Búsqueda de Usuario - find
const usuarios = [
    { id: 1, nombre: "Usuario A", activo: true },
    { id: 2, nombre: "Usuario B", activo: false },
    { id: 3, nombre: "Usuario C", activo: true }
];

const usuarioEncontrado = usuarios.find(usuario => usuario.id === 3);
console.log("Usuario encontrado:", usuarioEncontrado);

// Ejercicio 12: Contador de Usuarios Activos - filter y length
const usuariosActivos = usuarios.filter(usuario => usuario.activo);
console.log("Cantidad de usuarios activos:", usuariosActivos.length);

// Ejercicio 13: Actualización de Estado de Usuarios
usuarios.forEach(usuario => (usuario.activo = false));
console.log("Usuarios después de actualización:", usuarios);

// Ejercicio 14: Formateo de Productos para Mostrar - map
const productosFormato = catalogo.map(producto =>
    `Producto: ${producto.nombre}, Precio: $${producto.precio}`
);
console.log("Productos formateados:", productosFormato);

// Ejercicio 15
interface User {
    name: string;
    age: number;
    occupation: string;
}

const users: User[] = [
    {
        name: "Max Mustermann",
        age: 25,
        occupation: "Chimney sweep"
    },
    {
        name: "Kate Müller",
        age: 23,
        occupation: "Astronaut"
    }
];

function logPerson(user: User) {
    console.log(` - ${user.name}, ${user.age}`);
}

console.log("Usuarios:");
users.forEach(logPerson);

// Ejercicio 16
interface Admin {
    name: string;
    age: number;
    role: string;
}

type Person = User | Admin;

const persons: Person[] = [
    {
        name: "Max Mustermann",
        age: 25,
        occupation: "Chimney sweep"
    },
    {
        name: "Jane Doe",
        age: 32,
        role: "Administrator"
    },
    {
        name: "Kate Müller",
        age: 23,
        occupation: "Astronaut"
    },
    {
        name: "Bruce Willis",
        age: 64,
        role: "World saver"
    }
];

function logPersonV2(person: Person) {
    console.log(` - ${person.name}, ${person.age}`);
}

console.log("Personas:");
persons.forEach(logPersonV2);
