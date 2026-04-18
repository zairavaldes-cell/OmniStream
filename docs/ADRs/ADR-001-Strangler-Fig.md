# ADR 001: Estrategia de Migración – Strangler Fig vs Big Bang

## Estado
Aprobado

## Contexto
El sistema OmniStream fue desarrollado bajo una arquitectura monolítica, lo que limita su capacidad de escalabilidad ante el aumento de tráfico esperado. Se requiere extraer el Motor de Descuentos hacia un microservicio independiente sin interrumpir la operación del sistema actual.

## Decisión
Se adopta el patrón **Strangler Fig** como estrategia de migración progresiva, en lugar de una reescritura total del sistema (Big Bang).

## Alternativas Consideradas

### 1. Reescritura total (Big Bang)
Consiste en reconstruir completamente el sistema desde cero bajo una nueva arquitectura.

**Ventajas:**
- Arquitectura limpia desde el inicio
- Eliminación total de deuda técnica

**Desventajas:**
- Alto riesgo de fallos
- Requiere detener el sistema
- Alto costo y tiempo de desarrollo

---

### 2. Migración progresiva (Strangler Fig)
Permite extraer funcionalidades del monolito hacia microservicios de forma incremental.

**Ventajas:**
- No requiere detener el sistema
- Reduce riesgos
- Permite validación continua

**Desventajas:**
- Mayor complejidad temporal
- Coexistencia de dos arquitecturas

---

## Justificación
Se selecciona el patrón Strangler Fig debido a que permite una transición gradual sin afectar la disponibilidad del sistema. Esta estrategia reduce riesgos operativos y permite validar cada componente migrado antes de reemplazar completamente el sistema legado.

## Consecuencias

**Positivas:**
- Migración sin downtime
- Reducción de riesgos
- Implementación incremental

**Negativas:**
- Complejidad en la integración temporal
- Necesidad de mantener dos sistemas simultáneamente

## Decisión Final
Adoptar el patrón Strangler Fig como estrategia de modernización del sistema OmniStream.