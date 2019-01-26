import React, { Component } from 'react'
import Topics from './Topics';
import Chat from './Chat';

export default class ChatContainer extends Component {
  render() {
    return (
      <div>
        <Chat></Chat>
        <Topics></Topics>
      </div>
    )
  }
}
