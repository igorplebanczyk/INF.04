import { useState } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  const [title, setTitle] = useState("");
  const [type, setType] = useState("");

  return (
    <form onSubmit={(e) => {
      e.preventDefault();
      console.log(`tytul: ${title}; rodzaj: ${type}`);
    }}>
      <div className="form-group">
        <label htmlFor="input-title">Tytuł filmu</label>
        <input className="form-control" id="input-title" onChange={(e) => setTitle(e.target.value)}/>
      </div>

      <div className="form-group">
        <label htmlFor="select-type">Rodzaj</label>
        <select className="form-control" id="select-type" onChange={(e) => setType(e.target.value)}>
          <option></option>
          <option value="1">Komedia</option>
          <option value="2">Obyczajowy</option>
          <option value="3">Sensacyjny</option>
          <option value="4">Horror</option>
        </select>
      </div>

      <button className="btn btn-primary" type="submit">Dodaj</button>
    </form>
  );
}

export default App;
