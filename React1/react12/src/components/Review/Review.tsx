import "./Review.css";
type ReviewProps = {
    text: string;
    rating: number;
  };
  
  function Review({ text, rating }: ReviewProps) {
    return (
      <div className="review">
        <div className="review__rating">{rating}/5</div>
        <img src="/img/UserPhoto.png" alt="user" className="review__photo" />
        <div className="review__content">
          <span className="review__name">Это ты</span>
          <p className="review__text">{text}</p>
        </div>      
      </div>
    );
  }
  
  export default Review;