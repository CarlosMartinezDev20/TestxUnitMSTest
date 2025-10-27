# 🌡️ CAMC.Temperatura

**CAMC.Temperatura** es una solución desarrollada en **C# (.NET 8)** que contiene ejemplos prácticos de **manipulación de cadenas** y **conversión de temperaturas**, acompañados de **pruebas unitarias** en dos frameworks: **MSTest** y **xUnit**.

---

## 🧱 Estructura de la Solución

```
CAMC
├── CAMC.Temperatura
│   ├── StringManipulator.cs
│   └── TemperatureConverter.cs
│
├── CAMC.Temperatura.MSTest
│   ├── MSTestSettings.cs
│   └── TemperatureConverterTests.cs
│
└── CAMC.Temperatura.UnitTest
    └── StringManipulatorTest.cs
```

---

## 🧩 Descripción de Clases

### 🔠 StringManipulator

**Ubicación:** `CAMC.Temperatura/StringManipulator.cs`  
**Propósito:** Proporcionar funciones básicas para la manipulación de texto.

#### Métodos

| Método | Descripción | Ejemplo | Resultado Esperado |
|--------|--------------|----------|--------------------|
| `ReverseString(string input)` | Invierte los caracteres de una cadena. | `"casa"` | `"asac"` |
| `RemoveSpaces(string input)` | Elimina los espacios en blanco de una cadena. | `"hola mundo"` | `"holamundo"` |

#### Ejemplo de Uso

```csharp
var sm = new StringManipulator();
string r1 = sm.ReverseString("hola");
string r2 = sm.RemoveSpaces("mi casa");
Console.WriteLine($"{r1} - {r2}"); // aloh - micasa
```

---

### 🌡️ TemperatureConverter

**Ubicación:** `CAMC.Temperatura/TemperatureConverter.cs`  
**Propósito:** Convertir valores de temperatura entre escalas Celsius y Fahrenheit.

#### Métodos

| Método | Descripción | Ejemplo | Resultado Esperado |
|--------|--------------|----------|--------------------|
| `CelsiusToFahrenheit(double celsius)` | Convierte °C a °F. | `0` | `32.0` |
| `FahrenheitToCelsius(double fahrenheit)` | Convierte °F a °C. | `212` | `100.0` |

#### Ejemplo de Uso

```csharp
var temp = new TemperatureConverter();
double f = temp.CelsiusToFahrenheit(100); // 212.0
double c = temp.FahrenheitToCelsius(32);  // 0.0
```

---

## 🧪 Documentación de Pruebas Unitarias

### 🧷 1. Pruebas de `TemperatureConverter`

**Ubicación:** `CAMC.Temperatura.MSTest/TemperatureConverterTests.cs`  
**Framework:** MSTest  
**Clase probada:** `TemperatureConverter`

#### Objetivo
Validar que los cálculos matemáticos de conversión entre Celsius y Fahrenheit sean correctos.

#### Métodos probados

| Método | Tipo de Prueba | Casos Verificados | Resultado Esperado |
|---------|----------------|------------------|--------------------|
| `CelsiusToFahrenheit()` | Conversión directa | `0`, `100`, `-40` | `32.0`, `212.0`, `-40.0` |
| `FahrenheitToCelsius()` | Conversión inversa | `32`, `212`, `-40` | `0.0`, `100.0`, `-40.0` |

#### Código de prueba (MSTest)

```csharp
[TestMethod()]
public void CelsiusToFahrenheitTest()
{
    TemperatureConverter converter = new TemperatureConverter();

    double r1 = converter.CelsiusToFahrenheit(0);
    double r2 = converter.CelsiusToFahrenheit(100);
    double r3 = converter.CelsiusToFahrenheit(-40);

    Assert.AreEqual(32.0, r1);
    Assert.AreEqual(212.0, r2);
    Assert.AreEqual(-40.0, r3);
}
```

#### Resultado esperado
✔️ Todas las pruebas deben completarse correctamente confirmando la validez de las fórmulas de conversión.

---

### 🧷 2. Pruebas de `StringManipulator`

**Ubicación:** `CAMC.Temperatura.UnitTest/StringManipulatorTest.cs`  
**Framework:** xUnit  
**Clase probada:** `StringManipulator`

#### Objetivo
Comprobar el comportamiento de los métodos de manipulación de texto ante distintos tipos de entrada.

#### Métodos probados

| Método | Tipo de Prueba | Casos Verificados | Resultado Esperado |
|---------|----------------|------------------|--------------------|
| `ReverseString()` | Inversión de texto | `"casa"`, `"A"`, `""`, `"reconocer"` | `"asac"`, `"A"`, `""`, `"reconocer"` |
| `RemoveSpaces()` | Eliminación de espacios | `"hola mundo"`, `"  a b  c   "`, `""`, `"a\t b\n c"` | `"holamundo"`, `"abc"`, `""`, `"a\tb\nc"` |

#### Código de prueba (xUnit)

```csharp
[Fact]
public void RemoveSpacesTest()
{
    var sm = new StringManipulator();

    string r1 = sm.RemoveSpaces("hola mundo");
    string r2 = sm.RemoveSpaces("  a b  c   ");

    Assert.Equal("holamundo", r1);
    Assert.Equal("abc", r2);
}
```

#### Resultado esperado
✔️ Todas las pruebas deben pasar sin errores.  
❌ Si el valor de entrada es `null`, debe lanzarse una excepción `ArgumentNullException`.

---

## ⚙️ Ejecución de las pruebas

Desde la raíz del proyecto, ejecuta:

```bash
dotnet test
```

Esto ejecutará tanto las pruebas de **MSTest** como las de **xUnit**.

---

## 🎯 Conclusiones

El proyecto **CAMC.Temperatura** demuestra cómo implementar y probar correctamente clases básicas en **C#**.  
Se aplican principios de **modularidad**, **reutilización** y **testing automatizado** con distintos frameworks.

---

## 🧑‍💻 Autor

**Nombre:** Carlos Martinez
**Lenguaje:** C#  
**Framework:** .NET 8  
**Pruebas:** MSTest & xUnit  
📅 *Versión: Octubre 2025*  
💡 *Proyecto educativo para prácticas de pruebas unitarias y desarrollo limpio.*
