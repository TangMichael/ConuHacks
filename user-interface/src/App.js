import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import './App.css';
import ChatContainer from './Components/Call-Component/Containers/ChatContainer';

const Index = () => <h2>Home</h2>;

class App extends Component {
  render() {
    return (
      <div className="App">
      <Router>
    <div>
      <nav>
        <ul>
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <Link to="/chat/">Chat</Link>
          </li>
        </ul>
      </nav>

      <Route path="/" exact component={Index} />
      <Route path="/chat/" component={ChatContainer} />
    </div>
  </Router>
       
      </div>
    );
  }
}

export default App;
