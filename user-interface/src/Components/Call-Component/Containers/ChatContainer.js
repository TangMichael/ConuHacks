import React, { Component } from 'react'
import Topics from './Topics';
import Chat from './Chat';
import "./ChatContainer.css";
export default class ChatContainer extends Component {
  render() {
    return (
      <div className="container">
      <div className="chat">
        <Chat></Chat>
        </div>
        <div className="topics">
        <Topics></Topics>
        </div>
      </div>
    )
  }
}
