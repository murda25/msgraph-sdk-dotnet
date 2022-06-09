using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MediaContentRatingUnitedKingdom : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Movies rating selected for United Kingdom. Possible values are: allAllowed, allBlocked, general, universalChildren, parentalGuidance, agesAbove12Video, agesAbove12Cinema, agesAbove15, adults.</summary>
        public RatingUnitedKingdomMoviesType? MovieRating {
            get { return BackingStore?.Get<RatingUnitedKingdomMoviesType?>(nameof(MovieRating)); }
            set { BackingStore?.Set(nameof(MovieRating), value); }
        }
        /// <summary>TV rating selected for United Kingdom. Possible values are: allAllowed, allBlocked, caution.</summary>
        public RatingUnitedKingdomTelevisionType? TvRating {
            get { return BackingStore?.Get<RatingUnitedKingdomTelevisionType?>(nameof(TvRating)); }
            set { BackingStore?.Set(nameof(TvRating), value); }
        }
        /// <summary>
        /// Instantiates a new mediaContentRatingUnitedKingdom and sets the default values.
        /// </summary>
        public MediaContentRatingUnitedKingdom() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingUnitedKingdom CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingUnitedKingdom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingUnitedKingdomMoviesType>(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingUnitedKingdomTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingUnitedKingdomMoviesType>("movieRating", MovieRating);
            writer.WriteEnumValue<RatingUnitedKingdomTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}