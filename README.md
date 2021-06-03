# Objetivo de repositorio
Aplicación realizada en windows form para el control de inventario de una zapateria y funciona con un servicio REST para la persistencia de datos y una base de datos interna con **SQLite** para guardar configuración de aplicación y para eso se utilizo **Entitity Framework** en la app

## Requisitos
1. Tener corriendo o desplegado el proyecto API [Elipgo.ServiceAPI](https://github.com/campus-press/Elipgo.ServiceAPI) para consumo de información.
2. Url de servicio.
3. 3. Visual Studio **2017 o superior** [_En caso de correr aplicación en modo debug_]
4. Tener la versión [NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net472-web-installer) instalada para poder iniciar la aplicación.


## Instrucciones de uso
1. Iniciar aplicación en la cual validara las configuraciones inicales
![image](https://user-images.githubusercontent.com/18450989/120566140-3be0bf80-c3d4-11eb-9476-b1c7b5c4e462.png)

2. Ingresar `URL` de servicio REST [Elipgo.ServiceAPI](https://github.com/campus-press/Elipgo.ServiceAPI) para comunicación de datos.
![image](https://user-images.githubusercontent.com/18450989/120566262-7e0a0100-c3d4-11eb-8561-18627d0041d0.png)

>Si es la primera ves le mostrara una ventana de configuracióne en la cual se debe ingresar la dirección URL del servicio.

![image](https://user-images.githubusercontent.com/18450989/120567140-a2ff7380-c3d6-11eb-8394-edd217acd55a.png)

>Una ves que paso el test de conexion guardar configuración.
3. Ingresar usuario y contraseña para poder ingresar a aplicación 

![image](https://user-images.githubusercontent.com/18450989/120567171-b4488000-c3d6-11eb-8f10-e87004fbf071.png)
>Para poder ingresar ocupar usuario y contraseña de acuerdo a rol

Usuario | Contraseña
--- | ----
Admin   | Admin123
Basic   | basic123
