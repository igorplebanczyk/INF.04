import './App.css';
import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  const courses = ["Programowanie w C#", "Angular dla początkujących", "Kurs Django"];
  const [name, setName] = useState("");
  const [courseNumber, setCourseNumber] = useState(-1);

  return (
    <>
      <h2>Liczba kursów: {courses.length}</h2>

      <ol>{courses.map((e) => <li>{e}</li>)}</ol>

      <form onSubmit={(e) => {
          e.preventDefault();
          console.log(name);

          if (courseNumber >= 1 && courseNumber <= courses.length) {
            console.log(courses[courseNumber - 1]);
          } else {
            console.log("Nieprawidłowy numer kursu");
          }
        }}>
        <div className="form-group">
          <label htmlFor="input_name">Imię i nazwisko</label>
          <input className="form-control" type="text" id="input_name" onChange={(e) => setName(e.target.value)}></input>
        </div>

        <div className="form-group">
          <label htmlFor="input_course_number">Numer kursu</label>
          <input className="form-control" type="number" id="input_course_number" onChange={(e) => setCourseNumber(e.target.value)}></input>
        </div>

        <button type="submit" className="btn btn-primary">Zapisz do kursu</button>
      </form>
    </>
  );
}

export default App;
