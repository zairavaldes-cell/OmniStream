# OmniStream - Gestión de Suscripciones

Proyecto desarrollado bajo arquitectura de tres capas:

- Dominio: lógica de negocio pura
- Infraestructura: persistencia (JSON / SQL)
- Presentación: interfaz CLI

## Regla de negocio
Un usuario solo puede ser Premium si:
- Tiene saldo mayor a 50
- No tiene deudas

## Tecnologías
- C#
- .NET
- JSON (Newtonsoft)

## Patrón utilizado
- Repository Pattern
- Inyección de dependencias

## Ejecución
dotnet run --project PresentacionCLI
