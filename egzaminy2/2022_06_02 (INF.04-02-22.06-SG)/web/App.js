import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.css';

export default function App() {
  const courses = ["Programowanie w C#", "Angular dla początkujących", "Kurs Django"];

  const [name, setName] = useState("");
  const [selectedCourse, setSelectedCourse] = useState("");

  return (
    <>
      <h2>Liczba kursów: {courses.length}</h2>
      <ul>{courses.map((e, index) => <li key={index}>{e}</li>)}</ul>

      <form onSubmit={e => {
        e.preventDefault();
        console.log(name);
        
        if (selectedCourse >= 1 && selectedCourse <= courses.length) {
          console.log(courses[selectedCourse - 1]);
        } else {
          console.log("Nieprawidłowy numer kursu");
        }
      }}>
        <div className="form-group">
          <label htmlFor="inputName">Imię i nazwisko</label>
          <input className="form-control" id="inputName" onChange={e => setName(e.target.value)}/>
        </div>

        <div className="form-group">
          <label htmlFor="inputCourse">Numer kursu</label>
          <input className="form-control" id="inputCourse" onChange={e => setSelectedCourse(e.target.value)}/>
        </div>
        
        <button type="submit" className="btn btn-primary">Zapisz do kursu</button>
      </form>
    </>
  );
}
