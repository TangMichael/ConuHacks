import React, { Component } from "react";
import { ThemeProvider } from "@livechat/ui-kit";
import {
  Avatar,
  TitleBar,
  TextInput,
  MessageList,
  Message,
  MessageText,
  AgentBar,
  Title,
  Subtitle,
  MessageGroup,
  MessageButtons,
  MessageButton,
  MessageTitle,
  MessageMedia,
  TextComposer,
  Row,
  Fill,
  Fit,
  IconButton,
  SendButton,
  EmojiIcon,
  CloseIcon,
  Column,
  RateGoodIcon,
  RateBadIcon,
  Bubble
} from "@livechat/ui-kit";

export default class Chat extends Component {
  constructor() {
    super();
    //set the initial state
    this.state = { message: "ok", display: null };
    this.getNewMessage = this.getNewMessage.bind(this);
    this.myFunction = this.myFunction.bind(this);
        fetch('http://172.30.182.66:8080/api/values')
      .then(response => {response.json(); console.log(response.json())})
      .then(data => this.setState({ data }));
  }

  componentDidMount() {
    this.myFunction();
  }

  getNewMessage() {
    return this.setState({
      display: (
        <Message authorName="Visitor" isOwn={true}>
          <MessageText>{this.state.message}</MessageText>
        </Message>
      )
    });
  }

  myFunction() {
    var x = setInterval(this.getNewMessage, 3000);
  }

  render() {
    return (
      <ThemeProvider>
        <div>
          <MessageList active>
            <MessageGroup onlyFirstWithMeta>
              <Message authorName="Jon Smith" >
                <MessageText>No problem!</MessageText>
              </Message>
            </MessageGroup>
            <MessageGroup>{this.state.display}</MessageGroup>
          </MessageList>
        </div>
      </ThemeProvider>
    );
  }
}
