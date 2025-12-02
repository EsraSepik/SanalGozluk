# SanalGozluk
A WebAR E-Commerce Platform built with ASP.NET Core MVC. Features real-time Virtual Try-On using MindAR, face shape filtering, and a dynamic Admin Panel.
# 👓 SanalGozluk (Virtual Try-On E-Commerce)

**SanalGozluk** is a modern e-commerce web application that bridges the gap between online shopping and physical retail. It allows users to filter eyewear based on their face shape and **virtually try on glasses in real-time** using their webcam.

Built with **ASP.NET Core MVC (.NET 8)** and **WebAR technologies**.

## 🚀 Key Features

* **🕶️ Virtual Try-On (WebAR):** Users can see 3D models of glasses on their face in real-time using **MindAR** and **A-Frame**. No app installation required.
* **🧠 Smart Filtering:** Filters products based on Face Type (Oval, Square, Round) to improve user decision-making.
* **⚙️ Dynamic Admin Panel:** A full CRUD system for store owners to:
    * Upload new glasses.
    * Set prices and images.
    * **Fine-Tune AR Settings:** Adjust 3D model **Scale**, **Rotation**, and **Position** directly from the admin panel without touching the code.
* **💾 Database Management:** Uses **SQLite** with **Entity Framework Core** (Code-First approach).

## 🛠️ Tech Stack

* **Backend:** C#, ASP.NET Core MVC (.NET 8)
* **ORM:** Entity Framework Core
* **Database:** SQLite
* **Frontend:** Razor Views, Bootstrap 5, HTML5/CSS3
* **AR/3D:** MindAR (Face Tracking), A-Frame (3D Rendering), glTF/GLB Models

## 📸 Screenshots

*(You can upload screenshots of your project here)*

| Storefront | Virtual Try-On | Admin Panel |
|:---:|:---:|:---:|
| *(Place Image Here)* | *(Place Image Here)* | *(Place Image Here)* |

## 📦 Installation & Setup

1.  **Clone the repository**
    ```bash
    git clone [https://github.com/yourusername/SanalGozluk.git](https://github.com/yourusername/SanalGozluk.git)
    cd SanalGozluk
    ```

2.  **Restore Dependencies**
    ```bash
    dotnet restore
    ```

3.  **Setup Database**
    ```bash
    dotnet ef database update
    ```

4.  **Run the Project**
    ```bash
    dotnet run
    ```

5.  **Access the App**
    * **Storefront:** `http://localhost:5xxx/`
    * **Admin Panel:** `http://localhost:5xxx/Gozluk`

## 💡 How It Works

### 1. The AR Logic
The project uses `MindAR` for face mesh detection. The backend sends the 3D model URL (`.glb`) and specific positioning coordinates (Scale/Rotation) stored in the database to the frontend. The Javascript logic then renders the model on the user's nose bridge (Anchor 168).

### 2. Admin Capabilities
Unlike standard e-commerce sites, the Admin Panel includes **AR Configuration Fields**. Since every 3D model comes with different dimensions, the admin can manually tweak `Scale`, `Rotation`, and `Position` values to ensure the glasses fit perfectly on the user's face.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is open-source and available under the MIT License.
