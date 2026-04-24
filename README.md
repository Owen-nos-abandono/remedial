# Arroyo Seco – Gastronomía (.NET 8 MVC)

## Requisitos
- .NET 8 SDK
- Visual Studio 2022 o VS Code con extensión C#

## Ejecutar el proyecto

```bash
cd ArroyoSecoGastronomia
dotnet run
```

Luego abre: https://localhost:5001 (o el puerto que indique la consola)

## Credenciales de prueba
| Correo | Contraseña |
|---|---|
| oferente@gastronomia.com | password123 |
| admin@arroyoseco.com | admin123 |
| 2022371117@uteq.edu.mx | password123 |

## Flujo
1. La app abre en `/Account/Login`
2. Al iniciar sesión exitosamente, redirige a `/Dashboard`
3. El Dashboard muestra: banner de bienvenida, tarjetas de estadísticas, acciones rápidas y lista de restaurantes
