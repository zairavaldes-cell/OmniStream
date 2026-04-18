# ADR 002: Elección del Protocolo de Comunicación

## Estado
Aprobado

## Contexto
El sistema requiere comunicación entre el monolito legado y el nuevo microservicio de descuentos. Esta comunicación debe ser eficiente, confiable y fácil de implementar dentro de la infraestructura actual.

## Decisión
Se selecciona **REST (HTTP/JSON)** como protocolo de comunicación entre el monolito y el microservicio.

## Alternativas Consideradas

### 1. gRPC
Protocolo de alto rendimiento basado en HTTP/2.

**Ventajas:**
- Baja latencia
- Alta eficiencia

**Desventajas:**
- Mayor complejidad de implementación
- Requiere cambios en infraestructura

---

### 2. Mensajería asíncrona (RabbitMQ/Kafka)
Comunicación basada en eventos.

**Ventajas:**
- Alto desacoplamiento
- Escalabilidad

**Desventajas:**
- Mayor complejidad
- No necesario para comunicación directa

---

### 3. REST (HTTP/JSON)
Comunicación basada en APIs HTTP.

**Ventajas:**
- Fácil implementación
- Amplia compatibilidad
- Bajo costo

**Desventajas:**
- Mayor latencia comparado con gRPC
- Menor eficiencia en alto volumen extremo

---

## Justificación
REST es ampliamente utilizado y permite una integración rápida con el sistema actual. Su simplicidad reduce el tiempo de desarrollo y facilita la comunicación entre componentes durante la migración progresiva.

## Consecuencias

**Positivas:**
- Fácil integración
- Bajo costo de implementación
- Compatibilidad con herramientas existentes

**Negativas:**
- Rendimiento inferior a gRPC en escenarios extremos
- Posible necesidad de optimización futura

## Decisión Final
Utilizar REST como protocolo de comunicación entre el sistema monolítico y el microservicio de descuentos.