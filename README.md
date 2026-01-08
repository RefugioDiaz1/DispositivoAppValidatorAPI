# DeviceAccessApi

API backend desarrollada en **ASP.NET Core**, diseñada para el **control de acceso de aplicaciones móviles**, validación de dispositivos y registro de información de clientes.

Este proyecto funciona como un componente de seguridad e integración dentro de un ecosistema móvil empresarial.

---

## 🧠 Descripción general

**DeviceAccessApi** fue creada para centralizar la validación de dispositivos móviles y el almacenamiento de información básica de los usuarios, permitiendo restringir el uso de aplicaciones únicamente a dispositivos autorizados.

La API está pensada para ser consumida por aplicaciones móviles (Android / iOS), desacoplando la lógica de seguridad del cliente y manteniendo el control desde el backend.

---

## 🔐 Seguridad y control de acceso

La API implementa un mecanismo de control basado en el **identificador del dispositivo**, permitiendo:

- 📱 **Validación de dispositivos**
  - Solo dispositivos previamente registrados pueden utilizar la aplicación.
- 🚫 **Restricción de acceso**
  - Dispositivos no autorizados son bloqueados.
- 🗄️ **Persistencia segura**
  - Los datos se almacenan en una base de datos SQL Server.

Este enfoque ayuda a prevenir el uso no autorizado de aplicaciones internas.

---

## 📋 Funcionalidades implementadas

- 🔍 Validación de identificador único del dispositivo
- 👤 Registro de datos de contacto del cliente
- 🔒 Control de acceso a aplicaciones móviles
- 📡 API REST para consumo desde clientes móviles
- 🧱 Separación de responsabilidades (cliente / backend)

---

## 🏗️ Arquitectura y enfoque

- API desarrollada con **ASP.NET Core**
- Consumo vía HTTP desde aplicaciones móviles
- Persistencia de datos en **SQL Server**
- Diseño orientado a escalabilidad y extensibilidad

La API está preparada para integrarse con otras aplicaciones móviles o servicios adicionales.

---

## 🧪 Estado del proyecto

> ⚠️ **Proyecto en desarrollo / en pausa**

Actualmente, el proyecto se encuentra en estado **stand by**, con las funcionalidades base ya implementadas.  
La arquitectura quedó preparada para futuras ampliaciones.

---

## 🔮 Posibles mejoras futuras

- Autenticación basada en tokens (JWT)
- Roles y permisos por usuario
- Registro de actividad por dispositivo
- Rate limiting
- Integración con servicios de notificación
- Validaciones adicionales de seguridad

---

## 🧑‍💻 Tecnologías utilizadas

- ASP.NET Core
- C#
- API REST
- SQL Server
- Configuración segura de datos

---

## 🔗 Relación con otros proyectos

Esta API fue diseñada para integrarse con:

- Aplicaciones móviles desarrolladas en **.NET MAUI**
- Sistemas empresariales internos
- Servicios backend adicionales

---

## 👤 Autor

Desarrollado por **Refugio Díaz**  
Desarrollador de Software | Backend & Soluciones de Datos
