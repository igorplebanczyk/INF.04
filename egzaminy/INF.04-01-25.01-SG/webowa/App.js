import { useState } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';

export default function App() {
  const [images, setImages] = useState([
    {id: 0, alt: "Mak", filename: "obraz1.jpg", category:1, downloads: 35},
    {id: 1, alt:"Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43},
    {id: 2, alt:"Dalmatyńczyk", filename: "obraz3.jpg", category:2, downloads: 2},
    {id: 3, alt:"Świnka morska", filename: "obraz4.jpg", category:2, downloads: 53},
    {id: 4, alt:"Rotwailer", filename: "obraz5.jpg", category:2, downloads: 43},
    {id: 5, alt:"Audi", filename: "obraz6.jpg", category:3, downloads: 11},
    {id: 6, alt:"kotki", filename: "obraz7.jpg", category:2, downloads: 22},
    {id: 7, alt:"Róża", filename: "obraz8.jpg", category:1, downloads: 33},
    {id: 8, alt:"Świnka morska", filename: "obraz9.jpg", category:2, downloads: 123},
    {id: 9, alt:"Foksterier", filename: "obraz10.jpg", category:2, downloads: 22},
    {id: 10, alt:"Szczeniak", filename: "obraz11.jpg", category:2, downloads: 12},
    {id: 11, alt:"Garbus", filename: "obraz12.jpg", category:3, downloads: 321}
  ]);

  const flowerImages = images.filter(img => img.category === 1);
  const animalImages = images.filter(img => img.category === 2);
  const carImages = images.filter(img => img.category === 3);

  const [flowersChecked, setFlowersChecked] = useState(true);
  const [animalsChecked, setAnimalsChecked] = useState(true);
  const [carsChecked, setCarsChecked] = useState(true);

  const filteredImages = images.filter(img => {
    if (img.category === 1) return flowersChecked;
    if (img.category === 2) return animalsChecked;
    if (img.category === 3) return carsChecked;
    return false;
  });

  function handleDownload(id) {
    const updated = images.map(img => {
      if (img.id === id) {
        return {
          ...img,
          downloads: img.downloads + 1
        };
      }
      return img;
    });

    setImages(updated);
  }

  return (
    <>
      <h1>Kategorie zdjęć</h1>
      
      <div className="form-check form-switch form-check-inline">
        <input className="form-check-input" type="checkbox" id="switch_flowers" checked={flowersChecked} onChange={() => {
          const newValue = !flowersChecked;
          setFlowersChecked(newValue);
        }} />
        <label className="form-check-label" htmlFor="switch_flowers">Kwiaty</label>
      </div>

      <div className="form-check form-switch form-check-inline">
        <input className="form-check-input" type="checkbox" id="switch_animals" checked={animalsChecked} onChange={() => {
          const newValue = !animalsChecked;
          setAnimalsChecked(newValue);
        }} />
        <label className="form-check-label" htmlFor="switch_animals">Zwierzęta</label>
      </div>

      <div className="form-check form-switch form-check-inline">
        <input className="form-check-input" type="checkbox" id="switch_cars" checked={carsChecked} onChange={() => {
          const newValue = !carsChecked;
          setCarsChecked(newValue);
        }} />
        <label className="form-check-label" htmlFor="switch_cars">Samochody</label>
      </div>

      <div className="gallery">
        {filteredImages.map(img => {
        return (
          <div key={img.id}>
            <img src={"assets/" + img.filename} alt={img.alt} />
            <h4>Pobrań: {img.downloads}</h4>
            <button className="btn btn-success" onClick={() => handleDownload(img.id)}>Pobierz</button>
          </div>
        );
      })}
      </div>
    </>
  );
}   
